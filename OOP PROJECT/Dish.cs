using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using OOP_PROJECT.Properties;

namespace OOP_PROJECT
{
    public class Dish
    {
        #region Attributes
        private string name;
        private string menu;
        private string course;
        private int preptime;
        private int calories;
        private string description;
        private string[] allergens;
        private int price;
        private Image image;

        private List<Dish> dish = new List<Dish>();
        #endregion

        #region Constructors
        public Dish() { }
        public Dish(string n, int p)
        {
            name = n;   price = p;
        }
        #endregion

        #region Get - set  
        public string Name { get => name; set => name = value; }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Menu { get => menu; set => menu = value; }
        public string Course { get => course; set => course = value; }
        public int Preptime { get => preptime; set => preptime = value; }
        public int Calories { get => calories; set => calories = value; }
        public string Description { get => description; set => description = value; }
        public string[] Allergens { get => allergens; set => allergens = value; }
        public Image Image { get => image; set => image = value; }

        // get - set LIST of dishes
        public List<Dish> lstDish
        {
            get
            {
                List<Dish> lst = new List<Dish>();
                DocFile("C:/Users/sony/source/repos/OOP PROJECT/RefTextFiles/dishes2.TXT", ref lst);
                return lst;
            }
        }
        #endregion

        static void DocFile(string filename, ref List<Dish> dish)
        {
            StreamReader sw = new StreamReader(filename);   //mở tập tin
            string line;

            int i = 0;

            //Đọc dữ liệu từ tập tin
            sw.ReadLine();
            do
            {
                dish.Add(new Dish());
                //dish[i] = new Dish();
                line = sw.ReadLine();

                string[] words = line.Split('\t');
                dish[i].Name = words[0];                    //name
                dish[i].Menu = words[1];                    //menu
                dish[i].Course = words[2];                  //course
                dish[i].Preptime = int.Parse(words[3]);     //prep time
                dish[i].Calories = int.Parse(words[4]);     //calories

                string pr = words[5];                       //price
                pr.Remove(0, 1); //deletes the first quote
                pr.Remove(pr.Length - 1, 1);  //deletes the second quote
                pr.Replace(",", string.Empty);
                dish[i].Price = int.Parse(pr);        

                string rawallergens = words[6];             //allergens
                StringBuilder sb = new StringBuilder(rawallergens);
                if (words[6].Contains('"'))
                {
                    sb.Remove(0, 1); //deletes the first quote
                    sb.Remove(sb.Length - 1, 1);  //deletes the second quote
                }
                rawallergens = sb.ToString();
                string[] allergy = rawallergens.Split(',');
                dish[i].Allergens = allergy;

                dish[i].Description = words[7];             //description
                
                string imgname = dish[i].Name.Replace(' ', '_');     //image
                dish[i].Image = (Image)Resources.ResourceManager.GetObject(imgname);


                i++;
            } while (!sw.EndOfStream);

            sw.Close();
        }

        public void DisplayDish()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Menu: " + Menu);
            Console.WriteLine("Course: " + Course);
            Console.WriteLine("Preparation time: " + Preptime);
            Console.WriteLine("Calories: " + Calories);
            Console.WriteLine("Description: " + Description);
            Console.Write("Allergens: ");
            for (int i = 0; i < Allergens.Length - 1; i++)
                Console.Write(Allergens[i] + ", ");
            Console.WriteLine(Allergens[Allergens.Length - 1]);
            Console.WriteLine();
        }



    }
}
