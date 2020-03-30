using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_IBH_Alabanza
{
    public class Validaciones
    {


        public bool validaremail(string email)
        {
            if (email != "")
            {
                string expresion = "^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,4}$";
                if (Regex.IsMatch(email, expresion))
                {
                    if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Correo invalido");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Correo invalido");
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

       

        public bool validarTelefono(string tel)
        {
            if (tel != "")
            {
                string expresion = "^[2389]{1}[0-9]{7}$";
                if (Regex.IsMatch(tel, expresion))
                {
                    if (Regex.Replace(tel, expresion, String.Empty).Length == 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Telefono Incorrecto");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Telefono Incorrecto");
                    return false;
                }
            }
            else
            {
                return true;
            }
            
            
        }

        public bool validarIdentidad(string id)
        {
            if(id != "")
            {
                string expresion = "^[0-1]{1}[0-9]{1}[0-2]{1}[0-9]{1}[0-9]{9}$";
                if (Regex.IsMatch(id, expresion))
                {
                    if (Regex.Replace(id, expresion, String.Empty).Length == 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("identidad incorrecta");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("identidad incorrecta");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Campo identidad Vacio");
                return false;
            }
            


        }

        public bool validarNombre(string nombre, string msj)
        {
            if(nombre != "")
            {
                string expresion = "^[A-Z\\D]+$";
                if (Regex.IsMatch(nombre, expresion))
                {
                    if (Regex.Replace(nombre, expresion, String.Empty).Length == 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show(msj + " incorrecto");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show(msj + " incorrecto");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Campo " +msj+" Vacio");
                return false;
            }

        }

        public bool validarFrase(string frase, string msj)
        {
            if (frase != "")
            {
                string expresion = "^[0-9-A-Z\\D]+$";
                if (Regex.IsMatch(frase, expresion))
                {
                    if (Regex.Replace(frase, expresion, String.Empty).Length == 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Formato " + msj + " Incorrecto");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Formato " + msj + " Incorrecto");
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public bool validarCombo(ComboBox t, string msj)
        {
            if(t.SelectedIndex != 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Campo " + msj + " Vacio");
                return false;
            }
        }
        public bool validarNumero(string nombre, string msj)
        {
            if (nombre != "")
            {
                string expresion = "^[0-9\\D]+$";
                if (Regex.IsMatch(nombre, expresion))
                {
                    if (Regex.Replace(nombre, expresion, String.Empty).Length == 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show(msj + " incorrecto");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show(msj + " incorrecto");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Campo " + msj + " Vacio");
                return false;
            }

        }

    }
}
