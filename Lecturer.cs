﻿using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261002_w5
{
    class Lecturer
    {
        private string lecturerCode;
        private string lecturerName;
        private string lecturerLastname;
        private string lecturerPosition;

        public string LecturerCode
        {
            get { return this.lecturerCode; }
            set { this.lecturerCode = value; }
        }
        public string LecturerName
        {
            get { return this.lecturerName; }
            set { this.lecturerName = value; }
        }
        public string LecturerLastName
        {
            get { return this.lecturerLastname; }
            set { this.lecturerLastname = value; }
        }
        public string LecturerPosition
        {
            get { return this.lecturerPosition; }
            set { this.lecturerPosition = value; }
        }

        public Lecturer() { }
        public Lecturer(string lc, string ln, string ll, string lp)
        {
            this.LecturerCode = lc;
            this.LecturerName = ln;
            this.LecturerLastName = ll;
            this.LecturerPosition = lp;
        }

        public override string ToString()
        {
            return this.LecturerName + " ";
        }
    }
}
