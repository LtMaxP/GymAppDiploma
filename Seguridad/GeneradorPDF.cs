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
                Random random = new Random();
                int numero = random.Next(10000, 99999);

                FileStream pdfroot = new FileStream(rooTFoolder + "//Factura" + "_" + factura.Id_Factura + "_" + numero.ToString() + ".pdf", FileMode.Create, FileAccess.Write, FileShare.None);
                Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
                PdfWriter pw = PdfWriter.GetInstance(doc, pdfroot);

                doc.Open();
                doc.AddAuthor("TechExtreme");
                doc.AddTitle("PDF Generado");
                iTextSharp.text.Font standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                doc.Add(new Paragraph("Factura del documento TechExtreme - GymApp"));
                doc.Add(Chunk.NEWLINE);

                if (factura.Tipo == "Producto")
                {
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

                    tblPdf.AddCell(clProducto);
                    tblPdf.AddCell(clPrecio);
                    tblPdf.AddCell(clCantidad);

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
                }
                else
                {
                    PdfPTable tblPdf = new PdfPTable(2);
                    tblPdf.WidthPercentage = 100;

                    PdfPCell clFecha = new PdfPCell(new Phrase("Fecha de Pago", standardFont));
                    clFecha.BorderWidth = 0;
                    clFecha.BorderWidthBottom = 0.75f;
                    PdfPCell clCliente = new PdfPCell(new Phrase("Numero de Cliente", standardFont));
                    clCliente.BorderWidth = 0;
                    clCliente.BorderWidthBottom = 0.75f;

                    tblPdf.AddCell(clFecha);
                    tblPdf.AddCell(clCliente);

                    clFecha = new PdfPCell(new Phrase(factura.Fecha.ToString(), standardFont));
                    clFecha.BorderWidth = 0;

                    clCliente = new PdfPCell(new Phrase(factura.Id_Cliente.ToString(), standardFont));
                    clCliente.BorderWidth = 0;

                    tblPdf.AddCell(clFecha);
                    tblPdf.AddCell(clCliente);

                    doc.Add(tblPdf);
                }

                //Crear total
                PdfPTable tblPdffoot = new PdfPTable(2);
                tblPdffoot.WidthPercentage = 100;

                doc.Add(new Paragraph("Total de factura: "));
                PdfPCell cltotal = new PdfPCell(new Phrase("Total", standardFont));
                cltotal.BorderWidth = 0;
                cltotal.BorderWidthBottom = 0;
                tblPdffoot.AddCell(cltotal);

                cltotal = new PdfPCell(new Phrase(factura.Monto.ToString(), standardFont));
                cltotal.Border = 0;
                tblPdffoot.AddCell(cltotal);

                doc.Add(tblPdffoot);
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
