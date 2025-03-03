using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using tpr2_lvm.Properties;

namespace tpr2_lvm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listResources = new List<Resource>();
        }

        List<Resource> listResources;

        private void btnAddResource_Click(object sender, EventArgs e)
        {
            formResource frmResource = new formResource();
            if (frmResource.ShowDialog() == DialogResult.OK)
            {
                string resourceName = frmResource.resourceName; // Получите значение из формы 2
                if (resourceName != "")
                {
                    Resource resource = new Resource();
                    resource.Id = "R" + (listResources.Count + 1).ToString();
                    resource.Name = resourceName;
                    resource.DangerStates = new List<DangerState>();
                    listResources.Add(resource);
                    BindResourceData();

                }
            }
        }

        private void btnEditResource_Click(object sender, EventArgs e)
        {
            if (listResources.Count != 0)
            {
                string resourceName = listBoxResources.SelectedValue.ToString();
                int index = listBoxResources.SelectedIndex;
                formResource frmResource = new formResource(resourceName);
                if (frmResource.ShowDialog() == DialogResult.OK)
                {
                    resourceName = frmResource.resourceName; // Получите значение из формы 2
                    if (resourceName != "")
                    {
                        listResources[index].Name = resourceName;
                        BindResourceData();
                    }
                }
            }
        }

        private void btnDeleteResource_Click(object sender, EventArgs e)
        {
            if (listResources.Count != 0)
            {
                int index = listBoxResources.SelectedIndex;
                listResources.RemoveAt(index);
                BindResourceData();
            }
        }

        void BindResourceData()
        {
            listBoxResources.DataSource = null;
            listBoxResources.DataSource = GetResourceNames();
        }

        List<string> GetResourceNames()
        {
            List<string> resourceNames = new List<string>();
            foreach (Resource resource in listResources)
            {
                resourceNames.Add(resource.Name);
            }
            return resourceNames;
        }

        List<string> GetDangerStatesNames(Resource resource)
        {
            List<string> dangerStatesNames = new List<string>();
            foreach (DangerState state in resource.DangerStates)
            {
                dangerStatesNames.Add(state.Name);
            }
            return dangerStatesNames;
        }

        private void btnAddDangerState_Click(object sender, EventArgs e)
        {
            if (listResources.Count != 0)
            {
                FormDangerState formDangerState = new FormDangerState();
                int index = listBoxResources.SelectedIndex;
                Resource resource = listResources[index];
                if (formDangerState.ShowDialog() == DialogResult.OK)
                {
                    string dangerStateName;
                    dangerStateName = formDangerState.dangerStateName; // Получите значение из формы 2
                    double dangerStateLoss = formDangerState.loss;
                    if (dangerStateName != "")
                    {
                        DangerState dangerState = new DangerState();
                        dangerState.FAL = "";
                        dangerState.Formula = "";
                        dangerState.PF = "";
                        dangerState.Risk = 0;
                        dangerState.InitEvents = new List<InitEvent>();
                        dangerState.Id = "S" + (resource.DangerStates.Count + 1).ToString();
                        dangerState.Name = dangerStateName;
                        dangerState.loss = dangerStateLoss;
                        resource.DangerStates.Add(dangerState);

                        BindResourceData();
                    }
                }
            }

        }
        private void btnEditDangerState_Click(object sender, EventArgs e)
        {
            if (listResources.Count != 0)
            {
                string dangerStateName = listBoxDangerStates.SelectedValue.ToString();
                int index = listBoxDangerStates.SelectedIndex;
                int resIndex = listBoxResources.SelectedIndex;
                double dangerStateLoss = Convert.ToDouble(tbLoss.Text);
                FormDangerState formDangerState = new FormDangerState(dangerStateName, dangerStateLoss);

                Resource resource = listResources[resIndex];

                if (formDangerState.ShowDialog() == DialogResult.OK)
                {

                    dangerStateName = formDangerState.dangerStateName; // Получите значение из формы 2
                    dangerStateLoss = formDangerState.loss;
                    if (dangerStateName != "")
                    {
                        resource.DangerStates[index].Name = dangerStateName;
                        resource.DangerStates[index].loss = dangerStateLoss;
                        BindResourceData();
                    }
                }
            }
        }
        private void btnDeleteDangerState_Click(object sender, EventArgs e)
        {
            if (listResources.Count != 0)
            {
                int resIndex = listBoxResources.SelectedIndex;
                Resource resource = listResources[resIndex];

                if (resource.DangerStates.Count != 0)
                {
                    int index = listBoxDangerStates.SelectedIndex;
                    resource.DangerStates.RemoveAt(index);
                    BindResourceData();
                }
            }
        }

        private void listBoxResources_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxResources.SelectedIndex;


            if (index != -1)
            {
                listBoxDangerStates.DataSource = null;
                listBoxDangerStates.DataSource = GetDangerStatesNames(listResources[index]);
            }
        }

        private void listBoxDangerStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxDangerStates.SelectedIndex;
            if (index != -1)
            {
                string dangerStateName = listBoxDangerStates.SelectedItem.ToString();

                tbDangerState.Text = dangerStateName;

                int resIndex = listBoxResources.SelectedIndex;
                Resource resource = listResources[resIndex];

                tbFormula.Text = resource.DangerStates[index].Formula;
                tbFAL.Text = resource.DangerStates[index].FAL;
                tbPF.Text = resource.DangerStates[index].PF;
                tbRisk.Text = resource.DangerStates[index].Risk.ToString();
                tbProbability.Text = resource.DangerStates[index].P.ToString();
                tbLoss.Text = resource.DangerStates[index].loss.ToString();
                DangerState state = resource.DangerStates[index];
                listBoxInitEvents.DataSource = null;
                listBoxInitEvents.DataSource = GetInitEventsNames(state);
                listBoxProbabilities.DataSource = null;
                listBoxProbabilities.DataSource = GetInitEventsProbabilities(state);
            }
        }

        List<string> GetInitEventsNames(DangerState state)
        {
            List<string> initEventsNames = new List<string>();
            foreach (InitEvent initevent in state.InitEvents)
            {
                initEventsNames.Add(initevent.Id + " - " + initevent.Name);
            }
            return initEventsNames;
        }

        List<string> GetInitEventsProbabilities(DangerState state)
        {
            List<string> initEventsProbabiliries = new List<string>();
            foreach (InitEvent initevent in state.InitEvents)
            {
                initEventsProbabiliries.Add(initevent.P.ToString());
            }
            return initEventsProbabiliries;
        }


        private void bntAddInitEvent_Click(object sender, EventArgs e)
        {
            int resIndex = listBoxResources.SelectedIndex;
            if (resIndex != -1)
            {
                Resource resource = listResources[resIndex];
                if (resource.DangerStates.Count != 0)
                {
                    FormInitEvent formInitEvent = new FormInitEvent();
                    if (formInitEvent.ShowDialog() == DialogResult.OK)
                    {
                        int index = listBoxDangerStates.SelectedIndex;
                        DangerState state = resource.DangerStates[index];
                        InitEvent initEvent = new InitEvent();
                        initEvent.Name = formInitEvent.initEventName;
                        initEvent.P = formInitEvent.p;
                        initEvent.Id = "X" + (state.InitEvents.Count() + 1).ToString();
                        state.InitEvents.Add(initEvent);
                        BindResourceData();
                    }

                }
            }
        }

        private void bntDeleteInitEvent_Click(object sender, EventArgs e)
        {
            int resIndex = listBoxResources.SelectedIndex;
            if (resIndex != -1)
            {
                Resource resource = listResources[resIndex];
                if (resource.DangerStates.Count != 0)
                {
                    int index = listBoxDangerStates.SelectedIndex;
                    DangerState state = resource.DangerStates[index];

                    if (state.InitEvents.Count != 0)
                    {
                        int index_init = listBoxInitEvents.SelectedIndex;
                        state.InitEvents.RemoveAt(index_init);
                        BindResourceData();
                    }
                }
            }
        }

        private void bntEditInitEvent_Click(object sender, EventArgs e)
        {
            int resIndex = listBoxResources.SelectedIndex;
            if (resIndex != -1)
            {
                Resource resource = listResources[resIndex];
                if (resource.DangerStates.Count != 0)
                {
                    int index_init = listBoxInitEvents.SelectedIndex;
                    string initEventName = listBoxInitEvents.SelectedValue.ToString();
                    double p = Convert.ToDouble(listBoxProbabilities.SelectedValue);
                    FormInitEvent formInitEvent = new FormInitEvent(initEventName, p);
                    if (formInitEvent.ShowDialog() == DialogResult.OK)
                    {

                        int index = listBoxDangerStates.SelectedIndex;

                        resource.DangerStates[index].InitEvents[index_init].Name = formInitEvent.initEventName;
                        resource.DangerStates[index].InitEvents[index_init].P = formInitEvent.p;
                        BindResourceData();
                    }
                }
            }
        }

        private void listBoxInitEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxInitEvents.SelectedIndex;
            if (index != -1 && listBoxProbabilities.SelectedIndex != -1)
                listBoxProbabilities.SelectedIndex = index;

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fullPath = openFileDialog.FileName;

                Dictionary<string, Resource> resourceDict = new Dictionary<string, Resource>();

                try
                {
                    using (StreamReader reader = new StreamReader(fullPath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            // Разделение строки по символу ';'
                            List<string> elements = new List<string>(line.Split(';'));

                            // Парсинг данных из строки
                            string resId = elements[0];
                            string resName = elements[1];
                            string stateId = elements[2];
                            string stateName = elements[3];
                            string stateFormula = elements[4];
                            double stateLoss = double.Parse(elements[5]);
                            string eventId = elements[6];
                            string eventName = elements[7];
                            double eventP = double.Parse(elements[8]);


                            // Создание или получение ресурса
                            if (!resourceDict.TryGetValue(resId, out Resource resource))
                            {
                                resource = new Resource
                                {
                                    Id = resId,
                                    Name = resName,
                                    DangerStates = new List<DangerState>()
                                };
                                resourceDict[resId] = resource;
                            }

                            // Поиск или создание опасного состояния
                            DangerState dangerState = resource.DangerStates.FirstOrDefault(ds => ds.Id == stateId);
                            if (dangerState == null)
                            {
                                dangerState = new DangerState
                                {
                                    Id = stateId,
                                    Name = stateName,
                                    Formula = stateFormula,
                                    FAL = "",
                                    PF = "",
                                    Risk = 0,
                                    P = 0,
                                    loss = stateLoss,
                                    InitEvents = new List<InitEvent>()
                                };
                                resource.DangerStates.Add(dangerState);
                            }

                            // Создание инициирующего события
                            InitEvent initEvent = new InitEvent
                            {
                                Id = eventId,
                                Name = eventName,
                                P = eventP,
                            };
                            dangerState.InitEvents.Add(initEvent);
                        }
                    }

                    // Преобразование словаря в список ресурсов
                    listResources = resourceDict.Values.ToList();
                    BindResourceData();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошла ошибка при чтении файла: {ex.Message}");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter myOutputStream = new StreamWriter(saveFileDialog.FileName);
                foreach (Resource res in listResources)
                {
                    foreach (DangerState state in res.DangerStates)
                    {
                        foreach (InitEvent initEvent in state.InitEvents)
                        {
                            List<string> lst = new List<string> { res.Id, res.Name, state.Id, state.Name, state.Formula, state.loss.ToString(), initEvent.Id, initEvent.Name, initEvent.P.ToString() };

                            myOutputStream.WriteLine(string.Join(";", lst));
                        }
                    }

                }
                myOutputStream.Close();
            }
        }

        private void listBoxProbabilities_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxProbabilities.SelectedIndex;

            listBoxInitEvents.SelectedIndex = index;

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Проверка, что все Formula введены
            foreach (Resource res in listResources)
            {
                foreach (DangerState state in res.DangerStates)
                {
                    if (string.IsNullOrEmpty(state.Formula))
                    {
                        MessageBox.Show("Не все Formula введены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            // Проверка корректности Formula и преобразование в FAL
            foreach (Resource res in listResources)
            {
                foreach (DangerState state in res.DangerStates)
                {
                    // Получаем список допустимых идентификаторов инициирующих событий
                    HashSet<string> validEventIds = new HashSet<string>(state.InitEvents.Select(ie => ie.Id));

                    // Проверка корректности Formula
                    if (!IsFormulaValid(state.Formula, validEventIds))
                    {
                        MessageBox.Show($"Формула для ресурса {res.Id} опасного состояния {state.Id} содержит недопустимые элементы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Преобразование Formula в FAL
                    state.FAL = ConvertFormulaToFAL(state.Formula);
                    state.PF = ConvertFALToPF(state.FAL);
                    state.P = CountP(state.PF, state.InitEvents);
                    state.Risk = CountRisk(state);
                    tbAllRisk.Text = CountAllRisk().ToString();
                    BindResourceData();
                }
            }
        }

        // Метод для проверки корректности Formula
        private bool IsFormulaValid(string formula, HashSet<string> validEventIds)
        {
            // Удаляем все пробелы из формулы
            formula = formula.Replace(" ", "");

            // Проверяем, что в формуле используются только допустимые символы и идентификаторы
            foreach (char c in formula)
            {
                if (!(char.IsLetterOrDigit(c) || c == '&' || c == '|' || c == '(' || c == ')'))
                {
                    return false;
                }
            }

            // Проверяем, что все идентификаторы в формуле допустимы
            string[] tokens = formula.Split(new[] { '&', '|', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string token in tokens)
            {
                if (!validEventIds.Contains(token))
                {
                    return false;
                }
            }

            return true;
        }

        // Метод для преобразования Formula в FAL
        private string ConvertFormulaToFAL(string formula)
        {
            formula = formula.Replace("&", "*").Replace("|", "+");

            formula = formula.Replace("(", "").Replace(")", "");
            formula = formula.Replace("*", "∩").Replace("+", "U");

            return formula;
        }

        private string ConvertFALToPF(string formula)
        {
            formula = formula.Replace("∩", "*").Replace("U", "+");
            string pf = "1-(";
            string[] elems = formula.Split('+');
            foreach (string elem in elems)
            {
                pf += ($"(1-{elem})*"); 
            }
            pf = pf.Remove(pf.Length - 1);
            pf += ")";
            formula = pf;
            return formula;
        }

        private double CountP(string formula, List<InitEvent> initEvents)
        {
            string expression = formula;
            int i=1;
            foreach(InitEvent initEvent in initEvents)
            {
                expression = expression.Replace($"X{i}", initEvent.P.ToString());
                i++;
            }
            double result = Math.Round(EvaluateExpression(expression),5);
            return result;
        }

        private double EvaluateExpression(string expression)
        {
            expression = expression.Replace(",", ".");
            // Используем DataTable для вычисления выражения
            var table = new System.Data.DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            var row = table.NewRow();
            table.Rows.Add(row);
            return Convert.ToDouble(row["expression"]);
        }

        private double CountRisk(DangerState state)
        {          
            return state.loss * state.P;
        }
        private double CountAllRisk()
        {
            double count = 0;
            foreach(Resource resource in listResources)
            {
                foreach (DangerState state in resource.DangerStates)
                    count += state.Risk;
            }
            return count;
        }

        private void btnEnterFormula_Click(object sender, EventArgs e)
        {
            if (listResources.Count != 0)
            {
                int index = listBoxDangerStates.SelectedIndex;
                int resIndex = listBoxResources.SelectedIndex;
                DangerState state = listResources[resIndex].DangerStates[index];

                FormEnterFormula form = new FormEnterFormula(state.Formula);               

                if (form.ShowDialog() == DialogResult.OK)
                {
                    string formula = form.formula;
                    if (formula != "")
                    {
                        state.Formula = formula;
                        BindResourceData();
                    }
                }
            }
        }
    }
}
