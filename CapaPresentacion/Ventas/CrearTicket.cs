using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregamos las librerías que utilizaremos
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    //clase para crear el ticket de venta
    public class CrearTicket
    {
        //creamos un objeto de la clase stringbuilder, en este objeto agregamos las lineas del ticket
        StringBuilder linea = new StringBuilder();
        //creamos una variable que almacena el número máximo de caracteres
        int maxCar = 40;
        int cortar;

        //Método para dibujar una línea con guiones
        public string LineasGuion()
        {
            string lineasGuion = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasGuion += "-"; //agregará un guión hasta llegar al número máximo de caracteres
            }
            return linea.AppendLine(lineasGuion).ToString(); //devolvemos la linea guión
        }

        //Método para dibujar una línea con asteriscos
        public string LineasAsteriscos()
        {
            string lineasAsterisco = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasAsterisco += "*"; //agregará un asterisco hasta llegar al número máximo de caracteres
            }
            return linea.AppendLine(lineasAsterisco).ToString(); //devolvemos la linea asterisco
        }

        //Método para dibujar una línea con signo igual
        public string LineasIgual()
        {
            string lineasIgual = "";
            for (int i = 0; i < maxCar; i++)
            {
                lineasIgual += "-"; //agregará un igual hasta llegar al número máximo de caracteres
            }
            return linea.AppendLine(lineasIgual).ToString(); //devolvemos la linea igual
        }

        //Creamos un encabezado para los articulos
        public void EncabezadoVenta()
        {
            //Escribimos los espacios para mostrar el articulo. En total tiene que ser 40 caracteres
            linea.AppendLine("ARTICULO          CANT  PRECIO   TOTAL");
        }

        //Creamos un método para poner el texto a la izquierda
        public void TextoIzquierda(string texto)
        {
            //si la longitud del texto es mayor al número máximo de caracteres permitido, se corta el texto
            if(texto.Length > maxCar)
            {
                int caracterActual = 0; //nos indica en que caracter se quedó al bajar el texto a la sigte línea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //agregamos los fragmentos que salgan de texto
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                //agregamos el fragmento restante
                linea.AppendLine(texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                //si no es mayor sólo se agrega
                linea.AppendLine(texto);
            }
        }

        //Creamos un método para poner el texto a la derecha
        public void TextoDerecha(string texto)
        {
            //si la longitud del texto es mayor al número máximo de caracteres permitido, se corta el texto
            if (texto.Length > maxCar)
            {
                int caracterActual = 0; //nos indica en que caracter se quedó al bajar el texto a la sigte línea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //agregamos los fragmentos que salgan de texto
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                //variable para poner espacios restantes
                string espacios = " ";
                //obtenemos la longitud del texto restante
                for (int i = 0; i < (maxCar - texto.Substring(caracterActual, texto.Length - caracterActual).Length); i++)
                {
                    espacios += " "; //Agrega espacios para alinear a la derecha
                }
                //agregamos el fragmento restante, agregamos antes los espacios 
                linea.AppendLine(espacios + texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                string espacios = " ";
                //obtenemos la longitud del texto restante 
                for (int i = 0; i < (maxCar - texto.Length); i++)
                {
                    espacios += " "; //Agrega espacios para alinear a la derecha
                }
                //si no es mayor sólo se agrega
                linea.AppendLine(espacios + texto);
            }
        }

        //Método para centrar el texto
        public void TextoCentro(string texto)
        {
            //si la longitud del texto es mayor al número máximo de caracteres permitido, se corta el texto
            if (texto.Length > maxCar)
            {
                int caracterActual = 0; //nos indica en que caracter se quedó al bajar el texto a la sigte línea
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    //agregamos los fragmentos que salgan de texto
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                //variable para poner espacios restantes
                string espacios = " ";
                //obtenemos la cantidad de espacios libres, el resultado lo dividimos entre dos
                int centrar = (maxCar - texto.Substring(caracterActual, texto.Length - caracterActual).Length) / 2;
                //obtenemos la longitud del texto restante
                for (int i = 0; i < centrar; i++)
                {
                    espacios += " "; //Agrega espacios para alinear a la derecha
                }
                //agregamos el fragmento restante, agregamos antes los espacios 
                linea.AppendLine(espacios + texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                string espacios = " ";
                //obtenemos la longitud del texto restante 
                int centrar = (maxCar - texto.Length) / 2;
                //obtenemos la longitud del texto restante
                for (int i = 0; i < centrar; i++)
                {
                    espacios += " "; //Agrega espacios para alinear a la derecha
                }
                //agregamos el fragmento restante, agregamos antes los espacios 
                linea.AppendLine(espacios + texto);
            }
        }

            //Método para poner texto a los extremos
		public void TextoExtremos(string textoIzquierda, string textoDerecha)
		{
			//variables que utilizaremos
			string textoIzq, textoDer, textoCompleto = "", espacios = "";

			//si el texto que va a la izquierda es mayor a 18 cortamos el texto
			if (textoIzquierda.Length > 18)
			{
				cortar = textoIzquierda.Length - 18;
				textoIzq = textoIzquierda.Remove(18, cortar);
			}
			else
			{
				textoIzq = textoIzquierda;
			}
			textoCompleto = textoIzq; //agregamos el primer texto
			if (textoDerecha.Length > 20) // si es mayor a 20 lo cortamos
			{
				cortar = textoDerecha.Length - 20;
				textoDer = textoDerecha.Remove(20, cortar);
			}
			else
			{
				textoDer = textoDerecha;
			}
			//obtenemos el número de espacios restantes para poner texto derecho al final
			int nroEspacios = maxCar - (textoIzq.Length + textoDer.Length);

			for (int i = 0; i < nroEspacios; i++)
			{
				espacios += " "; //agrega los espacios para poner texto al final
			}
			textoCompleto += espacios + textoDerecha;  //agregamos el segundo texto, con los espacios para alinearlo a la derecha
            linea.AppendLine(textoCompleto);  //agregamos la línea al ticket
		}

        //Método para agregar los totales de la venta
        public void AgregarTotales(string texto, string total)
        {
            //variables que usaremos
            string resumen, valor, textoCompleto, espacios = "";

            if (texto.Length > 25)  //si es mayor a 25 lo cortamos
            {
                cortar = texto.Length - 25;
                resumen = texto.Remove(25, cortar);
            }
            else
            {
                resumen = texto;
            }
            textoCompleto = resumen;
            valor = total.ToString();  //agregamos el total 
            //obtenemos el número total de espacios restantes para alinearlo a la derecha
            int nroEspacios = maxCar - (resumen.Length + valor.Length);
            //agregamos los espacios
            for (int i = 0; i < nroEspacios; i++)
            {
                espacios = " ";
            }
            textoCompleto += espacios + valor;
            linea.AppendLine(textoCompleto);
        }

        //Método para agregar artículos al ticket de venta
        public void AgregaArticulo(string articulo, string cant, string precio, string importe)
        {
            //valída que cant, precio e importe estén dentro del rango
            if (cant.ToString().Length <= 5 && precio.ToString().Length <= 7 && importe.ToString().Length <= 8)
            {
                string elemento = "", espacios = "";
                bool bandera = false;   //indicará si es la primera línea que se escribe cuando bajemos a la segunda línea
                int nroEspacios = 0;

                //si el nombre del artículo es mayor a 20 bajar a la siguiente línea si el nombre no entra en la primera línea
                if (articulo.Length > 20)
                {
                    //colocar la cantidad a la derecha
                    nroEspacios = (5 - cant.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " "; // generamos los espacios para alinear a la derecha
                    }
                    elemento += espacios + cant.ToString();  //agregamos la cantidad con los espacios

                    //colocar el precio a la derecha
                    nroEspacios = (7 - precio.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";  //genera los espacios
                    }
                    elemento += espacios + precio.ToString();   //agregamos el precio con los espacios

                    //colocar el importe a la derecha
                    nroEspacios = (8 - importe.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " "; //genera los espacios
                    }
                    elemento += espacios + importe.ToString(); //agregamos el importe con los espacios

                    int caracterActual = 0;  //indicará en cual caracter se quedó al bajar a la segunda línea
                    //por cada 20 caracteres se agregará una línea sigte
                    for (int longitudTexto = articulo.Length; longitudTexto > 20; longitudTexto -= 20)
                    {
                        if (bandera == false)   //si es false o es la primera línea en recorrer
                        {
                            //agregamos los primeros 20 caracteres del nombre del artículo más lo que ya tiene la variable elemento
                            linea.AppendLine(articulo.Substring(caracterActual, 20) + elemento);
                            bandera = true;
                        }
                        else
                        {
                            linea.AppendLine(articulo.Substring(caracterActual, 20)); //solo agrega el artículo
                        }
                        caracterActual += 20;
                    }
                    //agrega el resto del fragmento del nombre del artículo
                    linea.AppendLine(articulo.Substring(caracterActual, articulo.Length - caracterActual));
                }
                //si el nombre del artículo no es mayor a 20, se agrega sin dar saltos de línea
                else
                {
                    for (int i = 0; i < (20 - articulo.Length); i++)
                    {
                        espacios += " "; //agrega espacios para completar los 20 caracteres
                    }
                    elemento = articulo + espacios;

                    //colocar la cantidad a la derecha
                    nroEspacios = (5 - cant.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + cant.ToString();

                    //colocar el precio a la derecha
                    nroEspacios = (7 - precio.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";  //genera los espacios
                    }
                    elemento += espacios + precio.ToString();   //agregamos el precio con los espacios

                    //colocar el importe a la derecha
                    nroEspacios = (8 - importe.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " "; //genera los espacios
                    }
                    elemento += espacios + importe.ToString(); //agregamos el importe con los espacios

                    linea.AppendLine(elemento);
                }
            }
            else
            {
                linea.AppendLine("Los valores ingresados para está fila");
                linea.AppendLine("superan las columnas soportadas por éste");
                throw new Exception("Los valores ingresados para algunas filas del ticket\nsuperan superan las columnas soportadas por éste.");
            }
        }

        //Métodos para enviar secuencias de escape a la impresora

        //Método para cortar el ticket
        public void CortaTicket()
        {
            linea.AppendLine("\x1B" + "m"); //caracter de corte. Este comando varía según el tipo de impresora
            linea.AppendLine("\x1B" + "d" + "\x09");    //avanza 9 reglones. También varía.
        }

        //Método para abrir el cajón
        public void AbreCajon()
        {
            //este comando varía según el tipo, verificar manual de impresora y cajón
            linea.AppendLine("\x1B" + "p" + "\x00" + "\x0F" + "\x96"); //caracteres de apertura cajón 0
            //linea.AppendLine("\x1B" + "p" + "\x01" + "\x0F" + "\x96"); //caracteres de apertura cajón 1
        }

        //Para mandar a imprimir el texto a la impresora que le indiquemos
        public void ImprimirTicket(string impresora)
        {
            //este método recibe el nombre de la impresora a la cual mandará a imprimir y el texto que se imprime
            RawPrinterHelper.SendStringToPrinter(impresora, linea.ToString()); //imprime texto
            linea.Clear();  //Al acabar de imprimir limpia la línea de todo el texto agregado
        }
    }

    //Clase para mandar a imprimir texto plano a la impresora
    public class RawPrinterHelper
    {
        // Structure and API declarions:
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

        // SendBytesToPrinter()
        // When the function is given a printer name and an unmanaged array
        // of bytes, the function sends those bytes to the print queue.
        // Returns true on success, false on failure.
        public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
         {
             Int32 dwError = 0, dwWritten = 0;
             IntPtr hPrinter = new IntPtr(0);
             DOCINFOA di = new DOCINFOA();
             bool bSuccess = false; // Assume failure unless you specifically succeed.

             di.pDocName = "Ticket de Venta"; //nombre con el que se guarda en caso de no imprimir
             di.pDataType = "RAW";

             // Open the printer.
             if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
             {
                 // Start a document.
                 if (StartDocPrinter(hPrinter, 1, di))
                 {
                     // Start a page.
                     if (StartPagePrinter(hPrinter))
                     {
                         // Write your bytes.
                         bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                         EndPagePrinter(hPrinter);
                     }
                     EndDocPrinter(hPrinter);
                 }
                 ClosePrinter(hPrinter);
             }
             // If you did not succeed, GetLastError may give more information
             // about why not.
             if (bSuccess == false)
             {
                 dwError = Marshal.GetLastWin32Error();
             }
             return bSuccess;
         }
         
        public static bool SendStringToPrinter(string szPrinterName, string szString)
        {
            IntPtr pBytes;
            Int32 dwCount;
            // How many characters are in the string?
            dwCount = szString.Length;
            // Assume that the printer is expecting ANSI text, and then convert
            // the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString);
            // Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount);
            Marshal.FreeCoTaskMem(pBytes);
            return true;
        }
    }
}
