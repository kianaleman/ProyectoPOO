using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaProyecto.Utilities
{
    public static class ControlUtils
    {
        public static void LimpiarTextBoxs(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c.HasChildren)
                {
                    LimpiarTextBoxs(c); // Llamada recursiva para limpiar TextBox en controles anidados
                }
            }
        }

        public static bool TextBoxsNoVacios(Control control, params TextBox[] exclusion)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox tb && !exclusion.Contains(tb) && string.IsNullOrWhiteSpace(tb.Text))
                {
                    MessageBox.Show("Todos los campos deben estar llenos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (c.HasChildren)
                {
                    if (!TextBoxsNoVacios(c, exclusion)) // Llamada recursiva para verificar TextBox en controles anidados
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static void HabilitarDeshabilitarControles(Control control, bool habilitar, params Control[] exclusion)
        {
            foreach (Control c in control.Controls)
            {
                if (!exclusion.Contains(c))
                {
                    c.Enabled = habilitar;
                }

                if (c.HasChildren)
                {
                    HabilitarDeshabilitarControles(c, habilitar, exclusion); // Llamada recursiva para controles anidados
                }
            }
        }

        //Retorna true si no esta vacio, y false si esta vacio
        public static bool IsTextBoxNotEmpty(TextBox textBox)
        {
            return !string.IsNullOrWhiteSpace(textBox.Text);
        }
    }
}
