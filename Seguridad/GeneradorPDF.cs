using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class GeneradorPDF
    {
        public static bool GenerarFactura(string rooTFoolder, BE.BE_Factura factura)
        {
            bool returnable = false;
            try
            {

                FileStream pdfroot = new FileStream(rooTFoolder, FileMode.Create);
                Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
                PdfWriter pw = PdfWriter.GetInstance(doc, pdfroot);

                doc.Open();
                doc.AddAuthor("TechExtreme");
                doc.AddTitle("PDF Generado");
                iTextSharp.text.Font standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                doc.Add(new Paragraph("Factura del documento"));
                doc.Add(Chunk.NEWLINE);

                PdfPTable tblPdf = new PdfPTable(3);
                tblPdf.WidthPercentage = 100;

                PdfPCell clProducto = new PdfPCell(new Phrase("Producto", standardFont));
                clProducto.BorderWidth = 0;
                clProducto.BorderWidthBottom = 0.75f;
                PdfPCell clPrecio = new PdfPCell(new Phrase("Precio", standardFont));
                clPrecio.BorderWidth = 0;
                clPrecio.BorderWidthBottom = 0.75f;
                PdfPCell clCantidad = new PdfPCell(new Phrase("Cantidad", standardFont));
                clCantidad.BorderWidth = 0;
                clCantidad.BorderWidthBottom = 0.75f;

                foreach (BE.Item Item in factura.Items)
                {
                    clProducto = new PdfPCell(new Phrase(Item.Descripcion, standardFont));
                    clProducto.BorderWidth = 0;

                    clPrecio = new PdfPCell(new Phrase(Item.Valor.ToString(), standardFont));
                    clPrecio.BorderWidth = 0;

                    clCantidad = new PdfPCell(new Phrase(Item.Cantidad.ToString(), standardFont));
                    clCantidad.BorderWidth = 0;

                    tblPdf.AddCell(clProducto);
                    tblPdf.AddCell(clPrecio);
                    tblPdf.AddCell(clCantidad);
                }

                doc.Add(tblPdf);
                returnable = true;
                doc.Close();
                pw.Close();
            }
            catch
            { }
            return returnable;
        }
    }
}
