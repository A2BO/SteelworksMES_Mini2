using DevExpress.XtraMap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesUI
{
    public partial class PurchaceFromOriginQuantity : Form
    {
        VectorItemsLayer BubbleChartDataAdapter1 { get { return (VectorItemsLayer)mapControl1.Layers["bubbleChartDataAdapter1"]; } }

        const string bingKey = "AgvMO35OGV6SrETYJ66iBZkuemtqDfYvwqHv4in8tjYI7TJU5zG5SZYI-3l-vZZC";
     
        public PurchaceFromOriginQuantity()
        {
            InitializeComponent();

            BingSearchDataProvider searchProvider = new BingSearchDataProvider()
            {
                BingKey = bingKey
            };


        }


    }
}