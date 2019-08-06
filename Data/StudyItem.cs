using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace StudyApp.Data
{
    public class StudyItem
    {
        public static XmlSerializer ItemSerializer;

        public const string ItemsDirectory = "Items";
        public const string PictureDirectory = "Pictures";

        public string FileName;

        public string[] Answers;

        public string Question { get; set; }
        public string Image { get; set; }
        public string Answer { get; set; }
        public string AnswerExplanation { get; set; }
        public string Group { get; set; }

        static StudyItem()
        {
            Directory.CreateDirectory(ItemsDirectory);
            Directory.CreateDirectory(PictureDirectory);

            ItemSerializer = new XmlSerializer(typeof(StudyItem));
        }

        public static StudyItem[] LoadAll()
        {
            string[] files = Directory.GetFiles(ItemsDirectory);
            StudyItem[] items = new StudyItem[files.Length];

            for (int i = 0; i < files.Length; i++)
            {
                string file = files[i];
                try
                {
                    FileStream stream = File.Open(file, FileMode.Open);
                    var dsi = (StudyItem) ItemSerializer.Deserialize(stream);
                    dsi.FileName = file;
                    items[i] = dsi;
                    stream.Close();
                }
                catch (Exception)
                {
                    // ignored
                }
            }

            items = items.OrderBy(x => x.Group).ToArray();

            return items;
        }

        public override string ToString()
        {
            return $"[{Group}] " + Question;
        }

        public StudyItem Clone()
        {
            return new StudyItem()
            {
                FileName = FileName,
                Question = Question,
                Image = Image,
                Answer = Answer,
                AnswerExplanation = AnswerExplanation,
                Group = Group
            };
        }
    }
}