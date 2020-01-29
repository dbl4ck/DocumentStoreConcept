﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentStoreConcepts.Models
{
    public class Document
    {
        public string GroupRef { get; set; }
        public string Filename { get; set; }
        public string Type { get; set; }
        public Image ThumbnailImage { get; set; }
    }
}
