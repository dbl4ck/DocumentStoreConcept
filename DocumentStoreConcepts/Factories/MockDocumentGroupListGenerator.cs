using DocumentStoreConcepts.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentStoreConcepts.Factories
{
    public class MockDocumentGroupListGenerator
    {
        public List<DocumentGroup> Generate()
        {
            var list = new List<DocumentGroup>();
            var random = new Random();

            var source = "pdf_120px.png";
            var w = 25;
            var h = 25;
            Image thumbnail = LoadThumbnail(source, w, h);

            for (var gi = 1; gi <= 40; gi++)
            {
                var groupRef = gi.ToString("000000");

                var group = new DocumentGroup()
                {
                    GroupRef = groupRef,
                    Delivered = DateTime.Now.AddDays(0 - gi),
                    Type = "Invoice",
                    Documents = new List<Document>()
                };

                var document_count = random.Next(2, 6);

                for (var di = 1; di <= document_count; di++)
                {
                    var document = new Document()
                    {
                        GroupRef = groupRef,
                        Filename = $"doc-{gi}-{di}.pdf",
                        Type = di != 3 ? "Invoice" : "BackingSheet",
                        ThumbnailImage = thumbnail
                    };

                    group.Documents.Add(document);
                }

                list.Add(group);
            }

            return list;
        }

        private static Bitmap LoadThumbnail(string source, int w, int h)
        {
            var thumbnail_source = Image.FromFile(source);
            var thumbnail = new Bitmap(w, h);
            var graphics = Graphics.FromImage(thumbnail);
            graphics.DrawImage(thumbnail_source, 0, 0, w, h);
            return thumbnail;
        }
    }
}
