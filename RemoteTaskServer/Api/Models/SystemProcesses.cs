﻿namespace RemoteTaskServer.Api.Models

{
    public class SystemProcesses
    {
        public int id { get; set; }
        public string path { get; set; }
        public string icon { get; set; }
        public string name { get; set; }
        public float cpuUsage { get; set; }
        public float ramUsage { get; set; }
        public float diskUsage { get; set; }
        public float networkUsage { get; set; }
    }
}