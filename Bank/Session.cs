using System;

namespace Bank
{
    static class Session
    {
        public static User User { get; set; }

        public static LogForm LogForm { get; set; }
        public static MainForm MainForm { get;  set; }
        public static DbContext Data { get; set; }
        public static Admin Admin { get;  set; }
    }
}