using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace Ejercicio17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Relaciona el metodo de manejo de eventos con cada boton de operacion//
            bSum.Click += OperacionesFilas_TextChanged;
            bRes.Click += OperacionesFilas_TextChanged;
            bMul.Click += OperacionesFilas_TextChanged;
            bDiv.Click += OperacionesFilas_TextChanged;

            //Relaciona el metodo de manejo de eventos con cada TextBox de la seleccion de lineas a operar//
            txtFila1.TextChanged += OperacionesFilas_TextChanged;
            txtFila2.TextChanged += OperacionesFilas_TextChanged;
            txtFila1.Click += OperacionesFilas_TextChanged;
            txtFila2.Click += OperacionesFilas_TextChanged;
        }

        //------------------------------Parametros Globales------------------------------//

        public const int TAMX = 10;
        public const int TAMY = 5;
        public int[,] vglobal = new int[TAMY, TAMX];
        public float sorted = 0.0f;
        public float action = 0.1f;
        public string signo = string.Empty;
        public string salida = "";

        //------------------------------Sistema de Escritura de Arrays------------------------------//

        /// <summary>
        /// Funcion que guarda un array unidimensional en uno bidimensional
        /// </summary>
        /// <param name="array">(int32)[,] Matriz bidimensional en la que estan los datos a guardar</param>
        /// <param name="numArray">(int32) Numero de fila a guardar en la Matriz principal</param>
        /// <param name="ArrayToWrite">(int32)[,] Matriz principal en la que se guarda el valor (Se escribe en la fila 0)</param>
        /// <returns>Devuelve la Matriz bidimensional con la Matriz unidimensional guardada</returns>
        void EscribirArray(int[,] array, int numArray, int[,] ArrayToWrite)
        {
            try
            {
                for (int i = 0; i < TAMX; i++)
                    ArrayToWrite[numArray, i] = array[0, i];
                MessageBox.Show($"Matriz de {TAMX} numeros ha sido creado con exito!");
            }
            catch { MessageBox.Show("Linea no valida"); }
            
        }
        /// <summary>
        /// Funciona de busqueda del valor mas alto de una matriz unidimensional
        /// </summary>
        /// <param name="array">(int32)[] Matriz unidensional a analizar</param>
        /// <returns>(int32) Valor maximo encontrado dentro de la matriz</returns>
        int MaxValue(int[] array)
        {
            int maxValue = 0;
            for (int j = 0; j < TAMX; j++)
            {
                if (array[j] > maxValue)
                {
                    maxValue = array[j];
                }
            }
            return maxValue;
        }
        /// <summary>
        /// Funcion que transforma un array bidimensional en uno unidimensional
        /// </summary>
        /// <param name="array">(int32)[,] Matriz bidimensional a convertir</param>
        /// <returns>(int32)[] Devuelve una matriz unidimensional directamente a la Matriz global</returns>
        void ArrayBiToUni(int[,] array)
        {
            int[] outputArray = new int[TAMX];
            int lonX = array.GetLength(0);
            int lonY = array.GetLength(1);
            int i = 0;

            while (i < TAMX)
            {
                int maxX = 0;
                int maxY = 0;
                for (int x = 0; x < lonX; x++)
                {
                    for (int y = 0; y < lonY; y++)
                    {
                        if (array[x, y] != 0)
                        {
                            if (array[x, y] > array[maxX, maxY])
                            {
                                maxX = x;
                                maxY = y;
                            }
                        }
                    }
                }
                outputArray[i] = array[maxX, maxY];
                array[maxX, maxY] = 0;
                i++;
            }
            for (int j = 0; j < outputArray.Length; j++)
                vglobal[0, j] = outputArray[j];
        }
        /// <summary>
        /// Algortimo de tipo Radix Sort que ordena los datos de un array unidimensional
        /// </summary>
        /// <param name="array">(int32)[] Matriz unidimensional a ordenar</param>
        /// <returns>(int32)[,] Devuelve un array bidimensional ordenado </returns>
        int[,] ASS(int[] array)
        {
            int[,] outputArray = new int[TAMX, MaxValue(array) + 1];
            int numDigitos = (int)Math.Floor(Math.Log10(MaxValue(array)) + 1);
            int indexNum;
            int r = 1;

            while (r <= numDigitos)
            {
                for (int i = 0; i < TAMX; i++)
                {
                    indexNum = (int)(array[i] / Math.Pow(10, (numDigitos - r)));
                    for (int x = 0; x < TAMX; x++)
                    {
                        if (indexNum == x)
                        {
                            for (int y = 1; y < TAMX; y++)
                            {
                                if (outputArray[y, x] == 0)
                                {
                                    outputArray[y, x] = array[i];
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }
                r++;
            }
            return (outputArray);
        }
        /// <summary>
        /// Funcion que invierte la primera linea de una matriz bidimensional
        /// </summary>
        /// <param name="array">(int32)[,] Matriz bidimensional sobre la que se trabaja</param>
        /// <returns>Devuelve la Matriz con la primera linea invertida</returns>
        void ReverseArray(int[,] array)
        {
            int[] outputArray = new int[array.GetLength(1)];
            int i = 0;
            int j = array.GetLength(1) - 1;
            while (i < array.GetLength(1) + 1 && j >= 0)
            {
                outputArray[j] = array[0, i];
                i++;
                j--;
            }
            for (int k = 0; k < array.GetLength(1); k++)
                vglobal[0, k] = outputArray[k];
        }

        //------------------------------Sistema de Lectura de Arrays------------------------------//

        /// <summary>
        /// Funcion que transforma una matriz bidimensional en un string
        /// </summary>
        /// <param name="array">(int32)[] Matriz a transformar en string</param>
        /// <param name="SelectRow">(bool) Boleano que indica si se selecciona fila o no</param>
        /// <param name="row">(int32) Fila a leer de la matriz</param>
        /// <returns>Imprime por pantalla el contenido del array completo o el contenido de la fila en cuestion</returns>
        void LeerArray(int[,] array, bool SelectRow = false, int row = 0)
        {
            try
            {
                if (array[row, 0] != 0)
                {
                    string salida = "";
                    if (SelectRow)
                    {
                        for (int i = 0; i < TAMX - 1; i++)
                        {
                            salida += array[row, i] + ", ";
                        }
                        salida += array[row, TAMX - 1];
                    }
                    else if (!SelectRow)
                    {
                        for (int i = 1; i < TAMY; i++)
                        {
                            salida += $"{i}.- ";
                            for (int j = 0; j < TAMX - 1; j++)
                            {
                                salida += array[i, j] + ", ";
                            }
                            salida += $"{array[i, TAMX - 1]}\n";
                        }
                    }
                    MessageBox.Show(salida);
                }
                else
                    MessageBox.Show($"No existe matriz en la fila {row}");
            }
            catch (IndexOutOfRangeException) { MessageBox.Show("Fila no valida"); }
            
        }
        /// <summary>
        /// Funcion que comprueba si una Matriz bidimensional tiene datos o no y lee una fila de la Matriz
        /// </summary>
        /// <param name="array">(int32)[,] Matriz bidimensional a comprobar y leer</param>
        /// <param name="numArray">(int32) Fila de la matriz a leer</param>
        /// <returns>Devuelve la fila de la Matriz si contiene datos o -1 en el indice 0 si esta vacio</returns>
        int[] SeleccionarArray(int[,] array, int numArray)
        {
            int[] output = new int[TAMX];
            try
            {
                if (array[numArray, 0] != 0)
                {
                    for (int i = 0; i < TAMX; i++)
                        output[i] = array[numArray, i];
                }
                else
                {
                    output[0] = -1;
                    MessageBox.Show($"La matriz {numArray} esta vacia");
                }
            }
            catch { }
            return output;
            
        }

        //------------------------------Sistema de Seleccion de Operacion------------------------------//

        /// <summary>
        /// Resalta el boton seleccionado
        /// </summary>
        /// <param name="op">(float)Valor de la operacion</param>
        string SeleccionarBoton(float op)
        {
            bSum.BackColor = System.Drawing.SystemColors.ControlLight;
            bSum.ForeColor = System.Drawing.SystemColors.ControlText;
            bRes.BackColor = System.Drawing.SystemColors.ControlLight;
            bRes.ForeColor = System.Drawing.SystemColors.ControlText;
            bMul.BackColor = System.Drawing.SystemColors.ControlLight;
            bMul.ForeColor = System.Drawing.SystemColors.ControlText;
            bDiv.BackColor = System.Drawing.SystemColors.ControlLight;
            bDiv.ForeColor = System.Drawing.SystemColors.ControlText;
            if (op == 0.1f)
            {
                signo = "+";
                bSum.BackColor = System.Drawing.SystemColors.Highlight;
                bSum.ForeColor = System.Drawing.SystemColors.Control;
            }
            if (op == 0.2f)
            {
                signo = "-";
                bRes.BackColor = System.Drawing.SystemColors.Highlight;
                bRes.ForeColor = System.Drawing.SystemColors.Control;
            }
            if (op == 0.3f)
            {
                signo = "*";
                bMul.BackColor = System.Drawing.SystemColors.Highlight;
                bMul.ForeColor = System.Drawing.SystemColors.Control;
            }
            if (op == 0.4f)
            {
                signo = "/";
                bDiv.BackColor = System.Drawing.SystemColors.Highlight;
                bDiv.ForeColor = System.Drawing.SystemColors.Control;
            }
            return signo;
        }
        /// <summary>
        /// Especifica un nuevo texto en base al indice del objeto del formulario
        /// </summary>
        /// <param name="indexBoton">(int32)Indice del objecto a buscar</param>
        /// <param name="textoBoton">(string)Texto a establecer en el objeto</param>
        void CambiarTextoBotones(int indexBoton, string textoBoton)
        {
            foreach (Control elementos in this.Controls)
            {
                if (elementos.TabIndex == indexBoton)
                {
                    elementos.Text = textoBoton;
                }
            }
        }

        //------------------------------Sistema de Comprobacion de Arrays------------------------------//

        bool MBSobreescribir(int lineaArray)
        {
            bool salida = true;
            if (vglobal[lineaArray, 0] > 0)
            {
                DialogResult seleccion = MessageBox.Show("Sobreescribir los datos", $"Desea sobreescribir los datos de la linea{lineaArray}", MessageBoxButtons.YesNo);
                if (seleccion == DialogResult.No) { salida = false; }
            }
            return salida;
        }

        //------------------------------Sistema de Botones------------------------------//

        //Crear la Matriz//
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int WhereSave = int.Parse(txtSaveArray.Text);
                if (MBSobreescribir(WhereSave))
                {
                    var rand = new Random();
                    sorted = 0.0f;
                    for (int i = 0; i < TAMX; i++)
                    {
                        vglobal[0, i] = rand.Next(50, 400);
                    }
                    EscribirArray(vglobal, WhereSave, vglobal);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show($"Selecciona donde guardar la Matriz");
            }

        }

        //Lee una linea concreta de la Matriz//
        private void bLookArray_Click(object sender, EventArgs e)
        {
            try
            {
                int WhereRead = int.Parse(txtReadArray.Text);
                if (salida == "")
                    LeerArray(vglobal, true, WhereRead);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingresa una Matriz a leer");
            }
        }

        //Lee la Matriz completa
        private void button1_Click_1(object sender, EventArgs e)
        {
            LeerArray(vglobal, false);
        }

        //Busca un valor especifico en la Matriz//
        private void bLookItem_Click(object sender, EventArgs e)
        {
            try
            {
                int WhereRead = int.Parse(txtReadArray.Text);
                if (WhereRead < TAMY)
                {
                    bool numFind = false;

                    string salida = null;
                    if (vglobal[0, WhereRead] != -1)
                    {
                        try
                        {
                            int numLook = int.Parse(Interaction.InputBox("Ingresa el numero a buscar", "Buscador de numeros", "Ingresa un numero"));
                            for (int i = 0; i < TAMX; i++)
                            {
                                if (vglobal[WhereRead, i] == numLook)
                                {
                                    numFind = true;
                                    if (salida == null)
                                        salida += ($"El numero {numLook} se encuentra en:");
                                    salida += ($"\n La posicion {i + 1} (Indice {i})");
                                }
                            }
                            if (numFind == false)
                                MessageBox.Show("No se encuentra el numero");
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Numero no valido, ingrese un numero valido para continuar");
                        }
                        if (numFind == true)
                            MessageBox.Show(salida);
                    }
                }
                else { throw new Exception("Linea no disponible"); }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese una linea a analizar");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //Ordena la Matriz ascendentemente//
        private void bSortArray_Click(object sender, EventArgs e)
        {
            try
            {
                int WhereRead = int.Parse(txtReadArray.Text);
                if (MBSobreescribir(WhereRead))
                {
                    int WhereSave = int.Parse(txtSaveArray.Text);
                    if (WhereRead > TAMY) { throw new Exception("Fila a leer no valida"); }
                    if (WhereSave > TAMY) { throw new Exception("Fila a escribir no vaida"); }
                    if (SeleccionarArray(vglobal, WhereRead)[0] != 0)
                    {
                        if (sorted == 0.0f)
                        {
                            ArrayBiToUni(ASS(SeleccionarArray(vglobal, WhereRead)));
                            ReverseArray(vglobal);
                            sorted = 0.1f;
                        }
                        if (sorted == 0.2f)
                        {
                            ReverseArray(vglobal);
                            sorted = 0.1f;
                        }
                        EscribirArray(vglobal, WhereSave, vglobal);
                        LeerArray(vglobal, true, WhereSave);
                    }
                    else { MessageBox.Show($"No existe array en la posicion {WhereRead}"); }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //Ordena la Matriz descendentemente//
        private void bSortArrayDes_Click(object sender, EventArgs e)
        {
            try
            {
                int WhereRead = int.Parse(txtReadArray.Text);
                if (MBSobreescribir(WhereRead))
                {
                    int WhereSave = int.Parse(txtSaveArray.Text);
                    if (WhereRead > TAMY - 1) { throw new Exception("Fila a leer no valida"); }
                    if (WhereSave > TAMY - 1) { throw new Exception("Fila a escribir no vaida"); }
                    if (SeleccionarArray(vglobal, WhereRead)[0] != 0)
                    {
                        if (sorted == 0.0f)
                        {
                            ArrayBiToUni(ASS(SeleccionarArray(vglobal, WhereRead)));
                            sorted = 0.2f;
                        }
                        if (sorted == 0.1f)
                        {
                            ReverseArray(vglobal);
                            sorted = 0.2f;
                        }
                        EscribirArray(vglobal, WhereSave, vglobal);
                        LeerArray(vglobal, true, WhereSave);
                    }
                    else { MessageBox.Show($"No existe array en la posicion {WhereRead}"); }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //Realiza una operacion con los datos de la Matriz 1//
        private void b1and2_Click(object sender, EventArgs e)
        {
            int[,] resultado = new int[1, TAMX];
            int[] fila1 = new int[TAMX];
            int[] fila2 = new int[TAMX];
            int WhereSave;
            int TxtFila1;
            int TxtFila2;
            string salida = "Resultado:\n";
            try
            {
                WhereSave = int.Parse(txtSaveArray.Text);
                if (MBSobreescribir(WhereSave))
                {
                    try
                    {
                        TxtFila1 = int.Parse(txtFila1.Text);
                        TxtFila2 = int.Parse(txtFila2.Text);
                        if (TxtFila1 >= TAMY || TxtFila2 >= TAMY)
                        {
                            throw new Exception("Fila no valida");
                        }
                        fila1 = SeleccionarArray(vglobal, TxtFila1);
                        fila2 = SeleccionarArray(vglobal, TxtFila2);
                        switch (action)
                        {
                            case 0.1f: { for (int i = 0; i < TAMX; i++) resultado[0, i] = fila1[i] + fila2[i]; break; };
                            case 0.2f: { for (int i = 0; i < TAMX; i++) resultado[0, i] = fila1[i] - fila2[i]; break; };
                            case 0.3f: { for (int i = 0; i < TAMX; i++) resultado[0, i] = fila1[i] * fila2[i]; break; };
                            case 0.4f: { for (int i = 0; i < TAMX; i++) resultado[0, i] = fila1[i] / fila2[i]; break; };
                        }
                        for (int num = 0; num < TAMX; num++)
                            salida += $"{resultado[0, num]}, ";
                        if (fila1[0] != -1 && fila2[0] != -1)
                        {
                            EscribirArray(resultado, WhereSave, vglobal);
                            MessageBox.Show(salida);
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Fila no valida para operar");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Espacio de guardado no valido");
            }
        }

        //Establece el texto del boton y cambia el operador
        private void OperacionesFilas_TextChanged(object sender, EventArgs e)
        {
            Control control = sender as Control;

            if (control != null)
            {
                try
                {
                    if((int.TryParse(control.Text, out int valorControl) && valorControl < TAMY) || control != null)
                    {
                        int fila1 = int.Parse(txtFila1.Text);
                        int fila2 = int.Parse(txtFila2.Text);
                        switch (control.Name)
                        {
                            case "bSum": { action = 0.1f; break; }
                            case "bRes": { action = 0.2f; break; }
                            case "bMul": { action = 0.3f; break; }
                            case "bDiv": { action = 0.4f; break; }
                        }
                        CambiarTextoBotones(8, $"Espacio {fila1} {SeleccionarBoton(action)} Espacio {fila2}");
                    }
                }
                catch { }
            }
        }
    }
}