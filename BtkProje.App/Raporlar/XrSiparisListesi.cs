using BtkProje.Model.Modeller;
using BtkProje.Servis;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace BtkProje.App.Raporlar
{
    public partial class XrSiparisListesi : DevExpress.XtraReports.UI.XtraReport
    {
        public XrSiparisListesi()
        {
            InitializeComponent();

            List<TblUrun> liste = DbServisi.KritikStokListesi();

            
            
          



            int i = 1;

            foreach(TblUrun u in liste) 
            {
                XRTableRow row = new XRTableRow();

                XRTableCell cell1 = new XRTableCell();
                cell1.Text = i.ToString();
                cell1.WidthF = xrTableRow1.Cells[0].WidthF;
                row.Cells.Add(cell1);
                ////////////////////////////////////////
                ///

                XRTableCell cell2 = new XRTableCell();
                cell2.Text = u.UrunAd;
                cell2.WidthF = xrTableRow1.Cells[1].WidthF;
                row.Cells.Add(cell2);

                ////////////////////////////////////////
                XRTableCell cell3 = new XRTableCell();
                cell3.Text = u.MinStok.ToString();
                cell3.WidthF = xrTableRow1.Cells[2].WidthF;
                row.Cells.Add(cell3);
                ////////////////////////////////////////
                XRTableCell cell4 = new XRTableCell();
                cell4.Text = u.MaksStok.ToString();
                cell4.WidthF = xrTableRow1.Cells[3].WidthF;
                row.Cells.Add(cell4);

                ////////////////////////////////////////
                XRTableCell cell5 = new XRTableCell();
                cell5.Text = DbServisi.MevcutStokHesapla(u).ToString();
                cell5.WidthF = xrTableRow1.Cells[4].WidthF;
                row.Cells.Add(cell5);

                xrTable1.Rows.Add(row);
                i++;
            }

           
        }
    }
}
