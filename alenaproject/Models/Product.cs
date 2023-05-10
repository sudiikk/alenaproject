using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.DirectoryServices;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace alenaproject.Models
{
    public class Product
        
    {

        public string Name { get; set; }
        public double Price { get; set; }

        public Guid ID { get; set; }
        
        public string Description { get; set; }

        [NotMapped]  public ImageSource QRCode { get; set; }

        
    }



    
}
