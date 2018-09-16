﻿using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gcWorld_Aerial_Proxy
{
    public partial class Form1 : Form
    {

        static Thread t;
        public static string provider = "google";
        public static string type = "satellite";
        public static string type_bing = "Aerial";

        static HttpListener listener;

        private static volatile bool _shouldStop = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string version = System.Windows.Forms.Application.ProductVersion;
            this.Text = String.Format("My Application Version {0}", version);

            int provider_setting = Properties.Settings.Default.provider;
            int google_settings = Properties.Settings.Default.google_settings;
            int bing_settings = Properties.Settings.Default.bing_settings;

            bingkey.Text = Properties.Settings.Default.bingkey;
            googlekey.Text = Properties.Settings.Default.googlekey;

            if (google_settings == 1) { radioButton1.Checked = true; type = "satellite"; }
            else if (google_settings == 2) { radioButton2.Checked = true; type = "roadmap"; }
            else if (google_settings == 3) { radioButton3.Checked = true; type = "hybrid"; }

            if (bing_settings == 1) { radioButton6.Checked = true; type_bing = "satellite"; }
            else if (bing_settings == 2) { radioButton5.Checked = true; type_bing = "roadmap"; }
            else if (bing_settings == 3) { radioButton4.Checked = true; type_bing = "hybrid"; }

            if (provider_setting == 1) { googlebtn.Checked = true; provider = "google"; }
            else if (provider_setting == 2) { bingbtn.Checked = true; provider = "bing"; }


            String[] prefixes = new String[1];
            prefixes[0] = "http://localhost:50123/";
            t = new Thread(new ThreadStart(NonblockingListener));
            t.Start();
        }

        public static void NonblockingListener()
        {
            listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:50123/");
            listener.Start();
            Console.WriteLine("Listening...");
            while (!_shouldStop)
            {
                Console.WriteLine("worker thread: working...");
                HttpListenerContext ctx = listener.GetContext();
                new Thread(new Worker(ctx).ProcessRequest).Start();
            }
            listener.Stop();
            Console.WriteLine("worker thread: terminating gracefully.");
        }

        public void RequestStop()
        {
            _shouldStop = true;
            listener.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            RequestStop();
            t.Abort();
            //listener2.Stop();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                type = "satellite";
                Properties.Settings.Default.google_settings = 1;
                Properties.Settings.Default.Save();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                type = "roadmap";
                Properties.Settings.Default.google_settings = 2;
                Properties.Settings.Default.Save();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                type = "hybrid";
                Properties.Settings.Default.google_settings = 3;
                Properties.Settings.Default.Save();
            }
        }

        private void googlebtn_CheckedChanged(object sender, EventArgs e)
        {
            if (googlebtn.Checked)
            {
                provider = "google";
                Properties.Settings.Default.provider = 1;
                Properties.Settings.Default.Save();
            }
        }

        private void bingbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (bingbtn.Checked)
            {
                provider = "bing";
                Properties.Settings.Default.provider = 2;
                Properties.Settings.Default.Save();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.microsoft.com/en-us/maps/licensing/options");
        }

        private void bingkey_TextChanged(object sender, EventArgs e)
        {
            bingkey_save.Enabled = true;
        }

        private void bingkey_save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.bingkey = bingkey.Text;
            Properties.Settings.Default.Save();
            bingkey_save.Enabled = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                type_bing = "Aerial";
                Properties.Settings.Default.bing_settings = 1;
                Properties.Settings.Default.Save();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                type_bing = "roadmap";
                Properties.Settings.Default.bing_settings = 2;
                Properties.Settings.Default.Save();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                type_bing = "hybrid";
                Properties.Settings.Default.bing_settings = 3;
                Properties.Settings.Default.Save();
            }
        }

        private void googlekey_save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.googlekey = googlekey.Text;
            Properties.Settings.Default.Save();
            googlekey_save.Enabled = false;
        }

        private void googlekey_TextChanged(object sender, EventArgs e)
        {
            googlekey_save.Enabled = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://developers.google.com/maps/documentation/maps-static/intro");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://cloud.google.com/maps-platform/terms/#3-license");
        }
    }

    class Worker
    {
        private HttpListenerContext context;
        private string imageUrl = "";
        private string[] subdomains;

        public Worker(HttpListenerContext context)
        {
            this.context = context;
        }

        public void ProcessRequest()
        {
            string msg = context.Request.HttpMethod + " " + context.Request.Url;
            Console.WriteLine(msg);

            StringBuilder sb = new StringBuilder();
            sb.Append("<html><body><h1>" + msg + "</h1>");
            //DumpRequest(context.Request, sb);
            sb.Append("</body></html>");

            string url = context.Request.Url.ToString();

            string[] param = url.Split('/');
            try
            {
                if (param[3] != "favicon.ico")
                {

                    Console.WriteLine("'" + param[3] + "'" + "'" + param[4] + "'" + "'" + param[5] + "'");

                    int x = int.Parse(param[3]);
                    int y = int.Parse(param[4]);
                    int z = int.Parse(param[5]);


                    //google base
                    //http://maps.googleapis.com/maps/api/staticmap?center=".toLatLong($_GET['x'], $_GET['y'], $_GET['z'])."&maptype=$type&zoom=".$_GET['z']."&size=".$res."&scale=".$scale."&sensor=false&format=".$format."&key=$apicode
                    string google_key = "";
                    if (Properties.Settings.Default.googlekey != "") google_key = Properties.Settings.Default.googlekey;

                    if (Form1.provider == "google")
                    {
                        WebRequest request = WebRequest.Create("http://maps.googleapis.com/maps/api/staticmap?center=" + toLatLong(x, y, z) + "&maptype=" + Form1.type + "&zoom=" + z + "&size=256x256&scale=1&sensor=false&format=jpg&key=" + google_key);
                        try
                        {
                            WebResponse response = request.GetResponse();
                            Stream dataStream = response.GetResponseStream();
                            context.Response.ContentType = "image/jpeg";
                            dataStream.CopyTo(context.Response.OutputStream);
                        } catch (WebException e)
                        {
                            Console.WriteLine("Error " + e);
                            Stream estream = e.Response.GetResponseStream();
                            StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                            // Read the content.
                            string responseFromServer = reader.ReadToEnd();
                            // Display the content.
                            Console.WriteLine(responseFromServer);
                            estream.CopyTo(context.Response.OutputStream);
                        }
                        
                    }
                    else if (Form1.provider == "bing")
                    {

                        if (imageUrl == "") GetBingMetadata();
                        GetBingImage(x, y, z);

                    }



                    context.Response.OutputStream.Close();
                }
            }
            catch (IndexOutOfRangeException e)
            {
                string responseString = "<HTML><BODY> ERROR!</BODY></HTML>";
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                context.Response.ContentType = "text/html";
                // Get a response stream and write the response to it.
                context.Response.ContentLength64 = buffer.Length;
                context.Response.StatusCode = 401;
                System.IO.Stream output = context.Response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                // You must close the output stream.
            }
        }

        public static void ListenerCallback(IAsyncResult result)
        {
            HttpListener listener = (HttpListener)result.AsyncState;
            // Call EndGetContext to complete the asynchronous operation.
            HttpListenerContext context = listener.EndGetContext(result);
            HttpListenerRequest request = context.Request;
            // Obtain a response object.
            HttpListenerResponse response = context.Response;
            // Construct a response.
            string responseString = "<HTML><BODY> Hello world!</BODY></HTML>";
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
            // Get a response stream and write the response to it.
            response.ContentLength64 = buffer.Length;
            System.IO.Stream output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
            // You must close the output stream.
            output.Close();
        }

        public string toLatLong(double x, double y, double z)
        {
            double n = Math.Pow(2, z);
            double lon_deg = (x + 0.5) / n * 360.0 - 180.0;
            double lat_deg = (Math.Atan(Math.Sinh(Math.PI * (1 - 2 * (y + 0.5) / n))));
            lat_deg = lat_deg * (180 / Math.PI);


            return lat_deg+","+lon_deg; ;
        }

        /// <summary>
        /// Converts tile XY coordinates into a QuadKey at a specified level of detail.
        /// </summary>
        /// <param name="tileX">Tile X coordinate.</param>
        /// <param name="tileY">Tile Y coordinate.</param>
        /// <param name="levelOfDetail">Level of detail, from 1 (lowest detail)
        /// to 23 (highest detail).</param>
        /// <returns>A string containing the QuadKey.</returns>
        public static string ToQuad(int tileX, int tileY, int levelOfDetail)
        {
            StringBuilder quadKey = new StringBuilder();
            for (int i = levelOfDetail; i > 0; i--)
            {
                char digit = '0';
                int mask = 1 << (i - 1);
                if ((tileX & mask) != 0)
                {
                    digit++;
                }
                if ((tileY & mask) != 0)
                {
                    digit++;
                    digit++;
                }
                quadKey.Append(digit);
            }
            return quadKey.ToString();
        }

        private void GetBingMetadata()
        {
            WebRequest request = WebRequest.Create("http://dev.virtualearth.net/REST/V1/Imagery/Metadata/" + Form1.type_bing + "?mapVersion=v1&output=json&key=" + Properties.Settings.Default.bingkey); //+ toLatLong(x, y, z) + "&maptype=" + Form1.type + "&zoom=" + z + "&size=256x256&scale=1&sensor=false&format=jpg&key=AIzaSyApknIRkAftJA_tlfnH88O1_EICgQuSYZg");
            WebResponse response = request.GetResponse();

            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            Console.WriteLine(responseFromServer);

            dynamic stuff = JsonConvert.DeserializeObject(responseFromServer);

            if ((int)stuff.statusCode == 200)
            {
                Console.WriteLine((String)stuff.resourceSets[0].resources[0].imageUrl);
                imageUrl = (String)stuff.resourceSets[0].resources[0].imageUrl;

                subdomains = stuff.resourceSets[0].resources[0].imageUrlSubdomains.ToObject<string[]>();
                Random rnd = new Random();
                int subdomain_nr = rnd.Next(0, subdomains.Length-1);
                string subdomain = subdomains[subdomain_nr];
                imageUrl = imageUrl.Replace("{subdomain}", subdomain);
                Console.WriteLine(subdomain);
            }
            else
            {
                string responseString = "<HTML><BODY> ERROR!</BODY></HTML>";
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                // Get a response stream and write the response to it.
                context.Response.ContentLength64 = buffer.Length;
                context.Response.ContentType = "text/html";
                context.Response.StatusCode = (int)stuff.statusCode;
                System.IO.Stream output = context.Response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                // You must close the output stream.
            }
        }

        private void GetBingImage(int x, int y, int z)
        {
            imageUrl = imageUrl.Replace("{quadkey}", ToQuad(x, y, z));
            WebRequest request = WebRequest.Create(imageUrl);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            context.Response.ContentType = "image/jpeg";
            dataStream.CopyTo(context.Response.OutputStream);
        }

        private Image DrawText(String text, Font font, Color textColor, Color backColor)
        {
            //first, create a dummy bitmap just to get a graphics object
            Image img = new Bitmap(1, 1);
            Graphics drawing = Graphics.FromImage(img);

            //measure the string to see how big the image needs to be
            SizeF textSize = drawing.MeasureString(text, font);

            //free up the dummy image and old graphics object
            img.Dispose();
            drawing.Dispose();

            //create a new image of the right size
            img = new Bitmap((int)textSize.Width, (int)textSize.Height);

            drawing = Graphics.FromImage(img);

            //paint the background
            drawing.Clear(backColor);

            //create a brush for the text
            Brush textBrush = new SolidBrush(textColor);

            drawing.DrawString(text, font, textBrush, 0, 0);

            drawing.Save();

            textBrush.Dispose();
            drawing.Dispose();

            return img;

        }
    }

}
