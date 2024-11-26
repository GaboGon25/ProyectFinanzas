using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinanzas
{
    public partial class FrmBalanceYEstado : Form
    {
        public FrmBalanceYEstado()
        {
            InitializeComponent();
        }

        private void FrmBalanceYEstado_Load(object sender, EventArgs e)
        {
            dgvBalanceGeneral.ColumnCount = 2;
            dgvBalanceGeneral.Columns[0].Name = "Descripción";
            dgvBalanceGeneral.Columns[1].Name = "Monto (USD)";
            dgvBalanceGeneral.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBalanceGeneral.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

            dgvEstadoDeResultado.ColumnCount = 2;
            dgvEstadoDeResultado.Columns[0].Name = "Descripción";
            dgvEstadoDeResultado.Columns[1].Name = "Monto (USD)";
            dgvEstadoDeResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEstadoDeResultado.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            if (DatosFinancieros.BalanceGeneral.Count == 0)
                DatosFinancieros.BalanceGeneral = BalanceGeneral();

            if (DatosFinancieros.EstadoResultados.Count == 0)
                DatosFinancieros.EstadoResultados = estadoResultados();

            ActualizarGrids();

        }


        private void ActualizarGrids()
        {
            dgvBalanceGeneral.Rows.Clear();
            foreach (var item in DatosFinancieros.BalanceGeneral)
            {
                dgvBalanceGeneral.Rows.Add(item.Descripcion, item.Monto);
            }

            dgvEstadoDeResultado.Rows.Clear();
            foreach (var item in DatosFinancieros.EstadoResultados)
            {
                dgvEstadoDeResultado.Rows.Add(item.Descripcion, item.Monto);
            }
        }


        private List<DatosBalance> BalanceGeneral()
        {
            return new List<DatosBalance>
            {
                new DatosBalance { Descripcion = "ACTIVOS CORRIENTES", Monto = "" },
                new DatosBalance { Descripcion = "Efectivo y equivalentes de efectivo", Monto = "1,086" },
                new DatosBalance { Descripcion = "Cuentas por cobrar, neto", Monto = "821" },
                new DatosBalance { Descripcion = "Inventarios", Monto = "559" },
                new DatosBalance { Descripcion = "Impuestos por recuperar", Monto = "401" },
                new DatosBalance { Descripcion = "Otros activos financieros corrientes", Monto = "57" },
                new DatosBalance { Descripcion = "Otros activos corrientes", Monto = "87" },
                new DatosBalance { Descripcion = "Total activos corrientes", Monto = "3,011" },
                new DatosBalance { Descripcion = "", Monto = "" },
                new DatosBalance { Descripcion = "Activos no corrientes", Monto = "" },
                new DatosBalance { Descripcion = "Inversiones en otras entidades", Monto = "517" },
                new DatosBalance { Descripcion = "Activos por derecho de uso", Monto = "73" },
                new DatosBalance { Descripcion = "Propiedad, planta y equipo, neto", Monto = "3,244" },
                new DatosBalance { Descripcion = "Activos intangibles, neto", Monto = "13,591" },
                new DatosBalance { Descripcion = "Activos por impuestos diferidos", Monto = "553" },
                new DatosBalance { Descripcion = "Otros activos financieros no corrientes", Monto = "11" },
                new DatosBalance { Descripcion = "Otros activos no corrientes", Monto = "321" },
                new DatosBalance { Descripcion = "Total activos no corrientes", Monto = "10,660" },
                new DatosBalance { Descripcion = "TOTAL ACTIVOS", Monto = "13,671" },
                new DatosBalance { Descripcion = "", Monto = "" },
                new DatosBalance { Descripcion = "PASIVOS Y CAPITAL", Monto = "" },
                new DatosBalance { Descripcion = "Pasivos corrientes", Monto = "" },
                new DatosBalance { Descripcion = "Préstamos bancarios y documentos por pagar", Monto = "47" },
                new DatosBalance { Descripcion = "Vencimiento a corto plazo del pasivo no corriente", Monto = "562" },
                new DatosBalance { Descripcion = "Vencimiento a corto plazo del pasivo por arrendamiento", Monto = "26" },
                new DatosBalance { Descripcion = "Intereses por pagar", Monto = "1,052" },
                new DatosBalance { Descripcion = "Proveedores", Monto = "548" },
                new DatosBalance { Descripcion = "Impuestos por pagar", Monto = "379" },
                new DatosBalance { Descripcion = "Otros pasivos financieros corrientes", Monto = "68" },
                new DatosBalance { Descripcion = "Total pasivos corrientes", Monto = "2,705" },
                new DatosBalance { Descripcion = "", Monto = "" },
                new DatosBalance { Descripcion = "Pasivos no corrientes", Monto = "" },
                new DatosBalance { Descripcion = "Préstamos bancarios y documentos por pagar", Monto = "3,101" },
                new DatosBalance { Descripcion = "Beneficios posteriores al retiro y otros beneficios a empleados", Monto = "1,135" },
                new DatosBalance { Descripcion = "Porción no corriente de pasivo por arrendamiento", Monto = "11" },
                new DatosBalance { Descripcion = "Otros pasivos no corrientes", Monto = "26" },
                new DatosBalance { Descripcion = "Provisiones y otros pasivos no corrientes", Monto = "1,602" },
                new DatosBalance { Descripcion = "Total pasivos no corrientes", Monto = "4,090" },
                new DatosBalance { Descripcion = "Total pasivos", Monto = "6,795" },
                new DatosBalance { Descripcion = "", Monto = "" },
                new DatosBalance { Descripcion = "CAPITAL", Monto = "" },
                new DatosBalance { Descripcion = "Capital Social", Monto = "109" },
                new DatosBalance { Descripcion = "Prima en suscripción de acciones", Monto = "2,416" },
                new DatosBalance { Descripcion = "Utilidades retenidas", Monto = "4,092" },
                new DatosBalance { Descripcion = "Otros ingresos de capital", Monto = "65" },
                new DatosBalance { Descripcion = "Capital atribuible a los propietarios de la controladora", Monto = "6,158" },
                new DatosBalance { Descripcion = "Participación no controladora en subsidiarias consolidadas", Monto = "718" },
                new DatosBalance { Descripcion = "Total capital", Monto = "6,876" },
                new DatosBalance { Descripcion = "TOTAL PASIVOS Y CAPITAL", Monto = "13,671" }
            };
        }

        private List<DatosEstadoResultado> estadoResultados()
        {
            return new List<DatosEstadoResultado>
            {
                new DatosEstadoResultado { Descripcion = "Ventas Netas", Monto = "$10,198" },
                new DatosEstadoResultado { Descripcion = "Otros Ingresos de Opeacion", Monto = "$113" },
                new DatosEstadoResultado { Descripcion = "Ingresos Totales", Monto = "$10,311" },
                new DatosEstadoResultado { Descripcion = "Costos Totals", Monto = "$5,671" },
                new DatosEstadoResultado { Descripcion = "Utilidad Bruta", Monto = "$4,640" },
                new DatosEstadoResultado { Descripcion = "Gastos de Administracion", Monto = "$447" },
                new DatosEstadoResultado { Descripcion = "Gastos de Venta", Monto = "$2,764" },
                new DatosEstadoResultado { Descripcion = "Otros Ingresos", Monto = "$100" },
                new DatosEstadoResultado { Descripcion = "Otros Gastos", Monto = "232" },
                new DatosEstadoResultado { Descripcion = "Gastos por Interes", Monto = "$366" },
                new DatosEstadoResultado { Descripcion = "Ingresos por Interes", Monto = "$65" },
                new DatosEstadoResultado { Descripcion = "(Perdida)Ganancia por fluctacion cambiaria,neta", Monto = "$(17)" },
                new DatosEstadoResultado { Descripcion = "Utilidad por composicion monetaria por subsidiarias en economia hiperinflacionarias", Monto = "$12" },
                new DatosEstadoResultado { Descripcion = "(Perdida)Ganancia en valor de mercado de instrumentos finnacieros", Monto = "$(15)" },
                new DatosEstadoResultado { Descripcion = "Utilidad(Perdida) antes de impuesto de operaciones continuas y participacion en los resultados de asociadas y negocios conjuntos", Monto = "$976" },
                new DatosEstadoResultado { Descripcion = "Impuesto a la Utilidad", Monto = "$399" },
                new DatosEstadoResultado { Descripcion = "Participacion en los esultados de Inversiones de capital, neta de impuestos", Monto = "$(7)" },
                new DatosEstadoResultado { Descripcion = "Utilidad(Perdida)neta de operaciones continuas", Monto = "$670" },
                new DatosEstadoResultado { Descripcion = "Utilidad(Perdida) neta consolidada", Monto = "$670" },
                new DatosEstadoResultado { Descripcion = "Valuacion de la porcion efectiva de instrumentos financieros derivados,neto de impuestos", Monto = "$(44)" },
                new DatosEstadoResultado { Descripcion = " Diferencias por efecto de conversion de operaciones y asociaas extranjeras", Monto = "$(296)" },
                new DatosEstadoResultado { Descripcion = "Otras partidas integrales netas que no sern reclasificadas a la (perdida) utilidad en periodos subsecuentes", Monto = "$(340)" },
                new DatosEstadoResultado { Descripcion = "Perdidas de activos financieros de patrimonio clasificado en FVOCI", Monto = "$(11)" },
                new DatosEstadoResultado { Descripcion = "Remedicion del pasivo neto por beneficios definidos neto de impuestos", Monto = "$(28)" },
                new DatosEstadoResultado { Descripcion = "Utilidad en periodos subsecuentes", Monto = "$(39)" },
                new DatosEstadoResultado { Descripcion = "Total de otra (perdida) utilidad integral, neta de impuestos", Monto = "(379)" },
                new DatosEstadoResultado { Descripcion = "Utilidad neta de impuestos consolidada por el año", Monto = "$291" }

            };

        }

        public void GenerarBalance(object sender, EventArgs e)
        {
            var balance = BalanceGeneral();
            dgvBalanceGeneral.Rows.Clear();
            foreach (var item in balance)
            {
                dgvBalanceGeneral.Rows.Add(item.Descripcion, item.Monto);
            }

            DatosFinancieros.BalanceGeneral = BalanceGeneral();
            ActualizarGrids();
        }

        public void GenerarEstado(object sender, EventArgs e)
        {
            var estado = estadoResultados();
            dgvEstadoDeResultado.Rows.Clear();
            foreach (var item in estado)
            {
                dgvEstadoDeResultado.Rows.Add(item.Descripcion, item.Monto);
            }

            DatosFinancieros.EstadoResultados = estadoResultados();
            ActualizarGrids();
        }

        public Dictionary<string, int> ObtenerDatos()
        {
            var datos = new Dictionary<string, int>();
            try
            {
                // Procesar datos del dgvBalanceGeneral
                foreach (DataGridViewRow row in dgvBalanceGeneral.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                    {
                        string nombreCuenta = row.Cells[0].Value.ToString();
                        int valorCuenta = Convert.ToInt32(row.Cells[1].Value);
                        datos[nombreCuenta] = valorCuenta;
                    }
                }

                // Procesar datos del dgvEstadoResultados
                foreach (DataGridViewRow row in dgvEstadoDeResultado.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                    {
                        string nombreCuenta = row.Cells[0].Value.ToString();
                        int valorCuenta = Convert.ToInt32(row.Cells[1].Value);

                        // Si ya existe una clave con el mismo nombre, sumar los valores
                        if (datos.ContainsKey(nombreCuenta))
                        {
                            datos[nombreCuenta] += valorCuenta;
                        }
                        else
                        {
                            datos[nombreCuenta] = valorCuenta;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener datos: {ex.Message}");
            }
            return datos;
        }

        private void FrmBalanceYEstado_Activated(object sender, EventArgs e)
        {
            ActualizarGrids();
        }
    }
}
    