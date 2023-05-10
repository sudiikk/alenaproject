﻿using alenaproject.Models;
using Microsoft.EntityFrameworkCore;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace alenaproject.Forms
{
    /// <summary>
    /// Логика взаимодействия для Dialog.xaml
    /// </summary>
    public partial class Dialog : Window
    {
        public Product Product { get; set; }
       
        public Dialog()
        {
            InitializeComponent();
            Product = new Product();
            DataContext = Product;
            Product.ID = Guid.NewGuid();
        }
        

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            
            {
                DatabaseContext db = new DatabaseContext();
                Product product = new Product
                {
                    Name = Product.Name,
                    Price = Product.Price,
                    Description = Product.Description,
                    ID = new Guid()
                };
                db.Database.Migrate();
                db.Products.Add(product);
                db.SaveChanges();
                MainWindow mainWindow = new MainWindow();
                this.Close();
                mainWindow.ShowDialog();
            }
           
        }


        
        public BitmapImage Convert(Bitmap src)
        {
            MemoryStream ms = new MemoryStream();
            ((System.Drawing.Bitmap)src).Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            ms.Seek(0, SeekOrigin.Begin);
            image.StreamSource = ms;
            image.EndInit();
            return image;

        }

        
    }
}
