﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OmronProject
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.heater1 = new OmronProject.Heater();
            this.panel5 = new OmronProject.OPanel();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.omronEdit29 = new OmronProject.OmronEdit();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.omronEdit30 = new OmronProject.OmronEdit();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.omronEdit31 = new OmronProject.OmronEdit();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.omronEdit32 = new OmronProject.OmronEdit();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.omronEdit33 = new OmronProject.OmronEdit();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.omronEdit34 = new OmronProject.OmronEdit();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.omronEdit35 = new OmronProject.OmronEdit();
            this.panel4 = new OmronProject.OPanel();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.PModeAlg = new OmronProject.OmronEdit();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.PCurrAlg = new OmronProject.OmronEdit();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.PMaxAlg = new OmronProject.OmronEdit();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.TProgramAlg = new OmronProject.OmronEdit();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.TErrorAlg = new OmronProject.OmronEdit();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.TTaskAlg = new OmronProject.OmronEdit();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.TStopAlg = new OmronProject.OmronEdit();
            this.panel3 = new OmronProject.OPanel();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.PModePit = new OmronProject.OmronEdit();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.PCurrPit = new OmronProject.OmronEdit();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.PMaxPit = new OmronProject.OmronEdit();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.TProgramPit = new OmronProject.OmronEdit();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.TErrorPit = new OmronProject.OmronEdit();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.TTaskPit = new OmronProject.OmronEdit();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.TStopPit = new OmronProject.OmronEdit();
            this.panel2 = new OmronProject.OPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.PModeBok = new OmronProject.OmronEdit();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.PCurrBok = new OmronProject.OmronEdit();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.PMaxBok = new OmronProject.OmronEdit();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.TProgramBok = new OmronProject.OmronEdit();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.TErrorBok = new OmronProject.OmronEdit();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.TTaskBok = new OmronProject.OmronEdit();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.TStopBok = new OmronProject.OmronEdit();
            this.panel1 = new OmronProject.OPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.PModeDno = new OmronProject.OmronEdit();
            this.TTaskDno = new OmronProject.OmronEdit();
            this.TProgramDno = new OmronProject.OmronEdit();
            this.PMaxDno = new OmronProject.OmronEdit();
            this.TStopDno = new OmronProject.OmronEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.PCurrDno = new OmronProject.OmronEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TErrorDno = new OmronProject.OmronEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(3, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(484, 212);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Время";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "d задания";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "d изм.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "d откл.";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Управление";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Поддерг.";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(738, 262);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Параметры";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(853, 262);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(116, 23);
            this.button7.TabIndex = 5;
            this.button7.Text = "Сигнализация";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(738, 288);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(109, 23);
            this.button8.TabIndex = 6;
            this.button8.Text = "Калибровка";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(853, 289);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(116, 23);
            this.button9.TabIndex = 7;
            this.button9.Text = "Графики";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(738, 317);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(853, 317);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(738, 343);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 160);
            this.textBox1.TabIndex = 10;
            // 
            // label81
            // 
            this.label81.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label81.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label81.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label81.Location = new System.Drawing.Point(3, 3);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(239, 23);
            this.label81.TabIndex = 11;
            this.label81.Text = "Донный нагреватель F1";
            // 
            // label82
            // 
            this.label82.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label82.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label82.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label82.Location = new System.Drawing.Point(240, 3);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(247, 23);
            this.label82.TabIndex = 12;
            this.label82.Text = "Боковой нагреватель F2";
            this.label82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label83
            // 
            this.label83.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label83.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label83.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label83.Location = new System.Drawing.Point(493, 3);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(239, 23);
            this.label83.TabIndex = 13;
            this.label83.Text = "Питатель F3";
            this.label83.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label84
            // 
            this.label84.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label84.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label84.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label84.Location = new System.Drawing.Point(738, 3);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(239, 23);
            this.label84.TabIndex = 14;
            this.label84.Text = "Алгоритм F4";
            this.label84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label85
            // 
            this.label85.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label85.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label85.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label85.Location = new System.Drawing.Point(3, 265);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(729, 23);
            this.label85.TabIndex = 15;
            this.label85.Text = "Параметры роста F5";
            this.label85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 509);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(729, 141);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // heater1
            // 
            this.heater1.Location = new System.Drawing.Point(739, 516);
            this.heater1.Name = "heater1";
            this.heater1.Size = new System.Drawing.Size(238, 134);
            this.heater1.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label65);
            this.panel5.Controls.Add(this.label66);
            this.panel5.Controls.Add(this.omronEdit29);
            this.panel5.Controls.Add(this.label67);
            this.panel5.Controls.Add(this.label68);
            this.panel5.Controls.Add(this.omronEdit30);
            this.panel5.Controls.Add(this.label69);
            this.panel5.Controls.Add(this.label70);
            this.panel5.Controls.Add(this.omronEdit31);
            this.panel5.Controls.Add(this.label71);
            this.panel5.Controls.Add(this.label72);
            this.panel5.Controls.Add(this.label73);
            this.panel5.Controls.Add(this.omronEdit32);
            this.panel5.Controls.Add(this.label74);
            this.panel5.Controls.Add(this.label75);
            this.panel5.Controls.Add(this.omronEdit33);
            this.panel5.Controls.Add(this.label76);
            this.panel5.Controls.Add(this.label77);
            this.panel5.Controls.Add(this.omronEdit34);
            this.panel5.Controls.Add(this.label78);
            this.panel5.Controls.Add(this.label79);
            this.panel5.Controls.Add(this.label80);
            this.panel5.Controls.Add(this.omronEdit35);
            this.panel5.Location = new System.Drawing.Point(493, 291);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(239, 212);
            this.panel5.TabIndex = 0;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(178, 189);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(26, 13);
            this.label65.TabIndex = 22;
            this.label65.Text = "Р/А";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(3, 189);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(42, 13);
            this.label66.TabIndex = 21;
            this.label66.Text = "Режим";
            // 
            // omronEdit29
            // 
            this.omronEdit29.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.omronEdit29.FieldDown = null;
            this.omronEdit29.FieldUp = null;
            this.omronEdit29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.omronEdit29.Location = new System.Drawing.Point(67, 182);
            this.omronEdit29.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.omronEdit29.MaxError = 0;
            this.omronEdit29.MinError = 0;
            this.omronEdit29.Name = "omronEdit29";
            this.omronEdit29.NumsAfterDot = 0;
            this.omronEdit29.Size = new System.Drawing.Size(105, 23);
            this.omronEdit29.State = OmronProject.OmronEdit.TState.Norma;
            this.omronEdit29.Step = 0F;
            this.omronEdit29.TabIndex = 20;
            this.omronEdit29.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.omronEdit29.Window = OmronProject.OmronEdit.TWindow.Dno;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(178, 166);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(15, 13);
            this.label67.TabIndex = 19;
            this.label67.Text = "%";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(3, 166);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(52, 13);
            this.label68.TabIndex = 18;
            this.label68.Text = "Текущая";
            // 
            // omronEdit30
            // 
            this.omronEdit30.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.omronEdit30.FieldDown = null;
            this.omronEdit30.FieldUp = null;
            this.omronEdit30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.omronEdit30.Location = new System.Drawing.Point(67, 159);
            this.omronEdit30.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.omronEdit30.MaxError = 0;
            this.omronEdit30.MinError = 0;
            this.omronEdit30.Name = "omronEdit30";
            this.omronEdit30.NumsAfterDot = 0;
            this.omronEdit30.Size = new System.Drawing.Size(105, 23);
            this.omronEdit30.State = OmronProject.OmronEdit.TState.Norma;
            this.omronEdit30.Step = 0F;
            this.omronEdit30.TabIndex = 17;
            this.omronEdit30.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.omronEdit30.Window = OmronProject.OmronEdit.TWindow.Dno;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(178, 146);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(15, 13);
            this.label69.TabIndex = 16;
            this.label69.Text = "%";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(3, 146);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(61, 13);
            this.label70.TabIndex = 15;
            this.label70.Text = "Максимум";
            // 
            // omronEdit31
            // 
            this.omronEdit31.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.omronEdit31.FieldDown = null;
            this.omronEdit31.FieldUp = null;
            this.omronEdit31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.omronEdit31.Location = new System.Drawing.Point(67, 137);
            this.omronEdit31.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.omronEdit31.MaxError = 0;
            this.omronEdit31.MinError = 0;
            this.omronEdit31.Name = "omronEdit31";
            this.omronEdit31.NumsAfterDot = 0;
            this.omronEdit31.Size = new System.Drawing.Size(105, 23);
            this.omronEdit31.State = OmronProject.OmronEdit.TState.Norma;
            this.omronEdit31.Step = 0F;
            this.omronEdit31.TabIndex = 14;
            this.omronEdit31.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.omronEdit31.Window = OmronProject.OmronEdit.TWindow.Dno;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label71.Location = new System.Drawing.Point(52, 116);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(107, 18);
            this.label71.TabIndex = 13;
            this.label71.Text = "Измеренные";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(178, 99);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(33, 13);
            this.label72.TabIndex = 12;
            this.label72.Text = "град.";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(3, 99);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(55, 13);
            this.label73.TabIndex = 11;
            this.label73.Text = "Програм.";
            // 
            // omronEdit32
            // 
            this.omronEdit32.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.omronEdit32.FieldDown = null;
            this.omronEdit32.FieldUp = null;
            this.omronEdit32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.omronEdit32.Location = new System.Drawing.Point(67, 92);
            this.omronEdit32.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.omronEdit32.MaxError = 0;
            this.omronEdit32.MinError = 0;
            this.omronEdit32.Name = "omronEdit32";
            this.omronEdit32.NumsAfterDot = 0;
            this.omronEdit32.Size = new System.Drawing.Size(105, 23);
            this.omronEdit32.State = OmronProject.OmronEdit.TState.Norma;
            this.omronEdit32.Step = 0F;
            this.omronEdit32.TabIndex = 10;
            this.omronEdit32.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.omronEdit32.Window = OmronProject.OmronEdit.TWindow.Dno;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(178, 73);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(33, 13);
            this.label74.TabIndex = 9;
            this.label74.Text = "град.";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(3, 73);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(27, 13);
            this.label75.TabIndex = 8;
            this.label75.Text = "Упр";
            // 
            // omronEdit33
            // 
            this.omronEdit33.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.omronEdit33.FieldDown = null;
            this.omronEdit33.FieldUp = null;
            this.omronEdit33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.omronEdit33.Location = new System.Drawing.Point(67, 70);
            this.omronEdit33.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.omronEdit33.MaxError = 0;
            this.omronEdit33.MinError = 0;
            this.omronEdit33.Name = "omronEdit33";
            this.omronEdit33.NumsAfterDot = 0;
            this.omronEdit33.Size = new System.Drawing.Size(105, 23);
            this.omronEdit33.State = OmronProject.OmronEdit.TState.Norma;
            this.omronEdit33.Step = 0F;
            this.omronEdit33.TabIndex = 7;
            this.omronEdit33.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.omronEdit33.Window = OmronProject.OmronEdit.TWindow.Dno;
            this.omronEdit33.TextChanged += new System.EventHandler(this.OmronEdit3TextChanged);
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(178, 51);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(33, 13);
            this.label76.TabIndex = 6;
            this.label76.Text = "град.";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(3, 51);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(57, 13);
            this.label77.TabIndex = 5;
            this.label77.Text = "Диам. кр.";
            // 
            // omronEdit34
            // 
            this.omronEdit34.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.omronEdit34.FieldDown = null;
            this.omronEdit34.FieldUp = null;
            this.omronEdit34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.omronEdit34.Location = new System.Drawing.Point(67, 44);
            this.omronEdit34.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.omronEdit34.MaxError = 0;
            this.omronEdit34.MinError = 0;
            this.omronEdit34.Name = "omronEdit34";
            this.omronEdit34.NumsAfterDot = 0;
            this.omronEdit34.Size = new System.Drawing.Size(105, 23);
            this.omronEdit34.State = OmronProject.OmronEdit.TState.Norma;
            this.omronEdit34.Step = 0F;
            this.omronEdit34.TabIndex = 4;
            this.omronEdit34.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.omronEdit34.Window = OmronProject.OmronEdit.TWindow.Dno;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label78.Location = new System.Drawing.Point(52, 4);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(177, 18);
            this.label78.TabIndex = 3;
            this.label78.Text = "Заданные параметры";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(178, 28);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(33, 13);
            this.label79.TabIndex = 2;
            this.label79.Text = "град.";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(3, 28);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(55, 13);
            this.label80.TabIndex = 1;
            this.label80.Text = "Скорость";
            // 
            // omronEdit35
            // 
            this.omronEdit35.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.omronEdit35.FieldDown = null;
            this.omronEdit35.FieldUp = null;
            this.omronEdit35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.omronEdit35.Location = new System.Drawing.Point(67, 25);
            this.omronEdit35.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.omronEdit35.MaxError = 0;
            this.omronEdit35.MinError = 0;
            this.omronEdit35.Name = "omronEdit35";
            this.omronEdit35.NumsAfterDot = 0;
            this.omronEdit35.Size = new System.Drawing.Size(105, 23);
            this.omronEdit35.State = OmronProject.OmronEdit.TState.Norma;
            this.omronEdit35.Step = 0F;
            this.omronEdit35.TabIndex = 0;
            this.omronEdit35.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.omronEdit35.Window = OmronProject.OmronEdit.TWindow.Dno;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label49);
            this.panel4.Controls.Add(this.label50);
            this.panel4.Controls.Add(this.PModeAlg);
            this.panel4.Controls.Add(this.label51);
            this.panel4.Controls.Add(this.label52);
            this.panel4.Controls.Add(this.PCurrAlg);
            this.panel4.Controls.Add(this.label53);
            this.panel4.Controls.Add(this.label54);
            this.panel4.Controls.Add(this.PMaxAlg);
            this.panel4.Controls.Add(this.label55);
            this.panel4.Controls.Add(this.label56);
            this.panel4.Controls.Add(this.label57);
            this.panel4.Controls.Add(this.TProgramAlg);
            this.panel4.Controls.Add(this.label58);
            this.panel4.Controls.Add(this.label59);
            this.panel4.Controls.Add(this.TErrorAlg);
            this.panel4.Controls.Add(this.label60);
            this.panel4.Controls.Add(this.label61);
            this.panel4.Controls.Add(this.TTaskAlg);
            this.panel4.Controls.Add(this.label62);
            this.panel4.Controls.Add(this.label63);
            this.panel4.Controls.Add(this.label64);
            this.panel4.Controls.Add(this.TStopAlg);
            this.panel4.Location = new System.Drawing.Point(738, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(239, 222);
            this.panel4.TabIndex = 0;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(178, 189);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(26, 13);
            this.label49.TabIndex = 22;
            this.label49.Text = "Р/А";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(3, 189);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(47, 13);
            this.label50.TabIndex = 21;
            this.label50.Text = "Подстр.";
            // 
            // PModeAlg
            // 
            this.PModeAlg.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.PModeAlg.FieldDown = null;
            this.PModeAlg.FieldUp = null;
            this.PModeAlg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PModeAlg.Location = new System.Drawing.Point(67, 182);
            this.PModeAlg.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.PModeAlg.MaxError = 0;
            this.PModeAlg.MinError = 0;
            this.PModeAlg.Name = "PModeAlg";
            this.PModeAlg.NumsAfterDot = 0;
            this.PModeAlg.Size = new System.Drawing.Size(105, 23);
            this.PModeAlg.State = OmronProject.OmronEdit.TState.Norma;
            this.PModeAlg.Step = 0F;
            this.PModeAlg.TabIndex = 20;
            this.PModeAlg.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.PModeAlg.Window = OmronProject.OmronEdit.TWindow.Algorithm;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(178, 166);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(15, 13);
            this.label51.TabIndex = 19;
            this.label51.Text = "%";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(3, 166);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(45, 13);
            this.label52.TabIndex = 18;
            this.label52.Text = "Период";
            // 
            // PCurrAlg
            // 
            this.PCurrAlg.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.PCurrAlg.FieldDown = null;
            this.PCurrAlg.FieldUp = null;
            this.PCurrAlg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PCurrAlg.Location = new System.Drawing.Point(67, 159);
            this.PCurrAlg.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.PCurrAlg.MaxError = 0;
            this.PCurrAlg.MinError = 0;
            this.PCurrAlg.Name = "PCurrAlg";
            this.PCurrAlg.NumsAfterDot = 0;
            this.PCurrAlg.Size = new System.Drawing.Size(105, 23);
            this.PCurrAlg.State = OmronProject.OmronEdit.TState.Norma;
            this.PCurrAlg.Step = 0F;
            this.PCurrAlg.TabIndex = 17;
            this.PCurrAlg.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.PCurrAlg.Window = OmronProject.OmronEdit.TWindow.Algorithm;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(178, 146);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(15, 13);
            this.label53.TabIndex = 16;
            this.label53.Text = "%";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(3, 146);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(42, 13);
            this.label54.TabIndex = 15;
            this.label54.Text = "Режим";
            // 
            // PMaxAlg
            // 
            this.PMaxAlg.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.PMaxAlg.FieldDown = null;
            this.PMaxAlg.FieldUp = null;
            this.PMaxAlg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PMaxAlg.Location = new System.Drawing.Point(67, 137);
            this.PMaxAlg.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.PMaxAlg.MaxError = 0;
            this.PMaxAlg.MinError = 0;
            this.PMaxAlg.Name = "PMaxAlg";
            this.PMaxAlg.NumsAfterDot = 0;
            this.PMaxAlg.Size = new System.Drawing.Size(105, 23);
            this.PMaxAlg.State = OmronProject.OmronEdit.TState.Norma;
            this.PMaxAlg.Step = 0F;
            this.PMaxAlg.TabIndex = 14;
            this.PMaxAlg.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.PMaxAlg.Window = OmronProject.OmronEdit.TWindow.Algorithm;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label55.Location = new System.Drawing.Point(52, 116);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(84, 18);
            this.label55.TabIndex = 13;
            this.label55.Text = "Подпитка";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(178, 99);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(33, 13);
            this.label56.TabIndex = 12;
            this.label56.Text = "град.";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(3, 99);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(58, 13);
            this.label57.TabIndex = 11;
            this.label57.Text = "Баз. уров.";
            // 
            // TProgramAlg
            // 
            this.TProgramAlg.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.TProgramAlg.FieldDown = null;
            this.TProgramAlg.FieldUp = null;
            this.TProgramAlg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TProgramAlg.Location = new System.Drawing.Point(67, 92);
            this.TProgramAlg.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.TProgramAlg.MaxError = 0;
            this.TProgramAlg.MinError = 0;
            this.TProgramAlg.Name = "TProgramAlg";
            this.TProgramAlg.NumsAfterDot = 0;
            this.TProgramAlg.Size = new System.Drawing.Size(105, 23);
            this.TProgramAlg.State = OmronProject.OmronEdit.TState.Norma;
            this.TProgramAlg.Step = 0F;
            this.TProgramAlg.TabIndex = 10;
            this.TProgramAlg.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.TProgramAlg.Window = OmronProject.OmronEdit.TWindow.Algorithm;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(178, 73);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(33, 13);
            this.label58.TabIndex = 9;
            this.label58.Text = "град.";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(3, 73);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(53, 13);
            this.label59.TabIndex = 8;
            this.label59.Text = "Поддерг.";
            // 
            // TErrorAlg
            // 
            this.TErrorAlg.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.TErrorAlg.FieldDown = null;
            this.TErrorAlg.FieldUp = null;
            this.TErrorAlg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TErrorAlg.Location = new System.Drawing.Point(67, 70);
            this.TErrorAlg.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.TErrorAlg.MaxError = 0;
            this.TErrorAlg.MinError = 0;
            this.TErrorAlg.Name = "TErrorAlg";
            this.TErrorAlg.NumsAfterDot = 0;
            this.TErrorAlg.Size = new System.Drawing.Size(105, 23);
            this.TErrorAlg.State = OmronProject.OmronEdit.TState.Norma;
            this.TErrorAlg.Step = 0F;
            this.TErrorAlg.TabIndex = 7;
            this.TErrorAlg.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.TErrorAlg.Window = OmronProject.OmronEdit.TWindow.Algorithm;
            this.TErrorAlg.TextChanged += new System.EventHandler(this.OmronEdit3TextChanged);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(178, 51);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(33, 13);
            this.label60.TabIndex = 6;
            this.label60.Text = "град.";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(3, 51);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(59, 13);
            this.label61.TabIndex = 5;
            this.label61.Text = "Весь цикл";
            // 
            // TTaskAlg
            // 
            this.TTaskAlg.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.TTaskAlg.FieldDown = null;
            this.TTaskAlg.FieldUp = null;
            this.TTaskAlg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TTaskAlg.Location = new System.Drawing.Point(67, 44);
            this.TTaskAlg.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.TTaskAlg.MaxError = 0;
            this.TTaskAlg.MinError = 0;
            this.TTaskAlg.Name = "TTaskAlg";
            this.TTaskAlg.NumsAfterDot = 0;
            this.TTaskAlg.Size = new System.Drawing.Size(105, 23);
            this.TTaskAlg.State = OmronProject.OmronEdit.TState.Norma;
            this.TTaskAlg.Step = 0F;
            this.TTaskAlg.TabIndex = 4;
            this.TTaskAlg.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.TTaskAlg.Window = OmronProject.OmronEdit.TWindow.Algorithm;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label62.Location = new System.Drawing.Point(52, 4);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(148, 18);
            this.label62.TabIndex = 3;
            this.label62.Text = "Параметры цикла";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(178, 28);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(33, 13);
            this.label63.TabIndex = 2;
            this.label63.Text = "град.";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(3, 28);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(33, 13);
            this.label64.TabIndex = 1;
            this.label64.Text = "Цикл";
            // 
            // TStopAlg
            // 
            this.TStopAlg.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.TStopAlg.FieldDown = null;
            this.TStopAlg.FieldUp = null;
            this.TStopAlg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TStopAlg.Location = new System.Drawing.Point(67, 25);
            this.TStopAlg.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.TStopAlg.MaxError = 0;
            this.TStopAlg.MinError = 0;
            this.TStopAlg.Name = "TStopAlg";
            this.TStopAlg.NumsAfterDot = 0;
            this.TStopAlg.Size = new System.Drawing.Size(105, 23);
            this.TStopAlg.State = OmronProject.OmronEdit.TState.Norma;
            this.TStopAlg.Step = 0F;
            this.TStopAlg.TabIndex = 0;
            this.TStopAlg.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.TStopAlg.Window = OmronProject.OmronEdit.TWindow.Algorithm;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label33);
            this.panel3.Controls.Add(this.label34);
            this.panel3.Controls.Add(this.PModePit);
            this.panel3.Controls.Add(this.label35);
            this.panel3.Controls.Add(this.label36);
            this.panel3.Controls.Add(this.PCurrPit);
            this.panel3.Controls.Add(this.label37);
            this.panel3.Controls.Add(this.label38);
            this.panel3.Controls.Add(this.PMaxPit);
            this.panel3.Controls.Add(this.label39);
            this.panel3.Controls.Add(this.label40);
            this.panel3.Controls.Add(this.label41);
            this.panel3.Controls.Add(this.TProgramPit);
            this.panel3.Controls.Add(this.label42);
            this.panel3.Controls.Add(this.label43);
            this.panel3.Controls.Add(this.TErrorPit);
            this.panel3.Controls.Add(this.label44);
            this.panel3.Controls.Add(this.label45);
            this.panel3.Controls.Add(this.TTaskPit);
            this.panel3.Controls.Add(this.label46);
            this.panel3.Controls.Add(this.label47);
            this.panel3.Controls.Add(this.label48);
            this.panel3.Controls.Add(this.TStopPit);
            this.panel3.Location = new System.Drawing.Point(493, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 222);
            this.panel3.TabIndex = 0;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(178, 189);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(26, 13);
            this.label33.TabIndex = 22;
            this.label33.Text = "Р/А";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(3, 189);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(42, 13);
            this.label34.TabIndex = 21;
            this.label34.Text = "Режим";
            // 
            // PModePit
            // 
            this.PModePit.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.PModePit.FieldDown = null;
            this.PModePit.FieldUp = null;
            this.PModePit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PModePit.Location = new System.Drawing.Point(67, 182);
            this.PModePit.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.PModePit.MaxError = 0;
            this.PModePit.MinError = 0;
            this.PModePit.Name = "PModePit";
            this.PModePit.NumsAfterDot = 0;
            this.PModePit.Size = new System.Drawing.Size(105, 23);
            this.PModePit.State = OmronProject.OmronEdit.TState.Norma;
            this.PModePit.Step = 0F;
            this.PModePit.TabIndex = 20;
            this.PModePit.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.PModePit.Window = OmronProject.OmronEdit.TWindow.Pit;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(178, 166);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(15, 13);
            this.label35.TabIndex = 19;
            this.label35.Text = "%";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(3, 166);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(52, 13);
            this.label36.TabIndex = 18;
            this.label36.Text = "Текущая";
            // 
            // PCurrPit
            // 
            this.PCurrPit.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.PCurrPit.FieldDown = null;
            this.PCurrPit.FieldUp = null;
            this.PCurrPit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PCurrPit.Location = new System.Drawing.Point(67, 159);
            this.PCurrPit.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.PCurrPit.MaxError = 0;
            this.PCurrPit.MinError = 0;
            this.PCurrPit.Name = "PCurrPit";
            this.PCurrPit.NumsAfterDot = 0;
            this.PCurrPit.Size = new System.Drawing.Size(105, 23);
            this.PCurrPit.State = OmronProject.OmronEdit.TState.Norma;
            this.PCurrPit.Step = 0F;
            this.PCurrPit.TabIndex = 17;
            this.PCurrPit.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.PCurrPit.Window = OmronProject.OmronEdit.TWindow.Pit;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(178, 146);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(15, 13);
            this.label37.TabIndex = 16;
            this.label37.Text = "%";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(3, 146);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(61, 13);
            this.label38.TabIndex = 15;
            this.label38.Text = "Максимум";
            // 
            // PMaxPit
            // 
            this.PMaxPit.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.PMaxPit.FieldDown = null;
            this.PMaxPit.FieldUp = null;
            this.PMaxPit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PMaxPit.Location = new System.Drawing.Point(67, 137);
            this.PMaxPit.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.PMaxPit.MaxError = 0;
            this.PMaxPit.MinError = 0;
            this.PMaxPit.Name = "PMaxPit";
            this.PMaxPit.NumsAfterDot = 0;
            this.PMaxPit.Size = new System.Drawing.Size(105, 23);
            this.PMaxPit.State = OmronProject.OmronEdit.TState.Norma;
            this.PMaxPit.Step = 0F;
            this.PMaxPit.TabIndex = 14;
            this.PMaxPit.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.PMaxPit.Window = OmronProject.OmronEdit.TWindow.Pit;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label39.Location = new System.Drawing.Point(52, 116);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(89, 18);
            this.label39.TabIndex = 13;
            this.label39.Text = "Мощность";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(178, 99);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(33, 13);
            this.label40.TabIndex = 12;
            this.label40.Text = "град.";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(3, 99);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(55, 13);
            this.label41.TabIndex = 11;
            this.label41.Text = "Програм.";
            // 
            // TProgramPit
            // 
            this.TProgramPit.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.TProgramPit.FieldDown = null;
            this.TProgramPit.FieldUp = null;
            this.TProgramPit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TProgramPit.Location = new System.Drawing.Point(67, 92);
            this.TProgramPit.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.TProgramPit.MaxError = 0;
            this.TProgramPit.MinError = 0;
            this.TProgramPit.Name = "TProgramPit";
            this.TProgramPit.NumsAfterDot = 0;
            this.TProgramPit.Size = new System.Drawing.Size(105, 23);
            this.TProgramPit.State = OmronProject.OmronEdit.TState.Norma;
            this.TProgramPit.Step = 0F;
            this.TProgramPit.TabIndex = 10;
            this.TProgramPit.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.TProgramPit.Window = OmronProject.OmronEdit.TWindow.Pit;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(178, 73);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(33, 13);
            this.label42.TabIndex = 9;
            this.label42.Text = "град.";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(3, 73);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(47, 13);
            this.label43.TabIndex = 8;
            this.label43.Text = "Ошибка";
            // 
            // TErrorPit
            // 
            this.TErrorPit.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.TErrorPit.FieldDown = null;
            this.TErrorPit.FieldUp = null;
            this.TErrorPit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TErrorPit.Location = new System.Drawing.Point(67, 70);
            this.TErrorPit.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.TErrorPit.MaxError = 0;
            this.TErrorPit.MinError = 0;
            this.TErrorPit.Name = "TErrorPit";
            this.TErrorPit.NumsAfterDot = 0;
            this.TErrorPit.Size = new System.Drawing.Size(105, 23);
            this.TErrorPit.State = OmronProject.OmronEdit.TState.Norma;
            this.TErrorPit.Step = 0F;
            this.TErrorPit.TabIndex = 7;
            this.TErrorPit.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.TErrorPit.Window = OmronProject.OmronEdit.TWindow.Pit;
            this.TErrorPit.TextChanged += new System.EventHandler(this.OmronEdit3TextChanged);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(178, 51);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(33, 13);
            this.label44.TabIndex = 6;
            this.label44.Text = "град.";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(3, 51);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(50, 13);
            this.label45.TabIndex = 5;
            this.label45.Text = "Задание";
            // 
            // TTaskPit
            // 
            this.TTaskPit.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.TTaskPit.FieldDown = null;
            this.TTaskPit.FieldUp = null;
            this.TTaskPit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TTaskPit.Location = new System.Drawing.Point(67, 44);
            this.TTaskPit.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.TTaskPit.MaxError = 0;
            this.TTaskPit.MinError = 0;
            this.TTaskPit.Name = "TTaskPit";
            this.TTaskPit.NumsAfterDot = 0;
            this.TTaskPit.Size = new System.Drawing.Size(105, 23);
            this.TTaskPit.State = OmronProject.OmronEdit.TState.Norma;
            this.TTaskPit.Step = 0F;
            this.TTaskPit.TabIndex = 4;
            this.TTaskPit.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.TTaskPit.Window = OmronProject.OmronEdit.TWindow.Pit;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label46.Location = new System.Drawing.Point(52, 4);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(109, 18);
            this.label46.TabIndex = 3;
            this.label46.Text = "Температура";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(178, 28);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(33, 13);
            this.label47.TabIndex = 2;
            this.label47.Text = "град.";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(3, 28);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(50, 13);
            this.label48.TabIndex = 1;
            this.label48.Text = "Останов";
            // 
            // TStopPit
            // 
            this.TStopPit.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.TStopPit.FieldDown = null;
            this.TStopPit.FieldUp = null;
            this.TStopPit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TStopPit.Location = new System.Drawing.Point(67, 25);
            this.TStopPit.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.TStopPit.MaxError = 0;
            this.TStopPit.MinError = 0;
            this.TStopPit.Name = "TStopPit";
            this.TStopPit.NumsAfterDot = 0;
            this.TStopPit.Size = new System.Drawing.Size(105, 23);
            this.TStopPit.State = OmronProject.OmronEdit.TState.Norma;
            this.TStopPit.Step = 0F;
            this.TStopPit.TabIndex = 0;
            this.TStopPit.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.TStopPit.Window = OmronProject.OmronEdit.TWindow.Pit;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.PModeBok);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.PCurrBok);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.PMaxBok);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.TProgramBok);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.TErrorBok);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.TTaskBok);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.label31);
            this.panel2.Controls.Add(this.label32);
            this.panel2.Controls.Add(this.TStopBok);
            this.panel2.Location = new System.Drawing.Point(248, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 222);
            this.panel2.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(178, 189);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Р/А";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 189);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Режим";
            // 
            // PModeBok
            // 
            this.PModeBok.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.PModeBok.FieldDown = null;
            this.PModeBok.FieldUp = null;
            this.PModeBok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PModeBok.Location = new System.Drawing.Point(67, 182);
            this.PModeBok.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.PModeBok.MaxError = 0;
            this.PModeBok.MinError = 0;
            this.PModeBok.Name = "PModeBok";
            this.PModeBok.NumsAfterDot = 0;
            this.PModeBok.Size = new System.Drawing.Size(105, 23);
            this.PModeBok.State = OmronProject.OmronEdit.TState.Norma;
            this.PModeBok.Step = 0F;
            this.PModeBok.TabIndex = 20;
            this.PModeBok.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.PModeBok.Window = OmronProject.OmronEdit.TWindow.Bok;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(178, 166);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "%";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 166);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "Текущая";
            // 
            // PCurrBok
            // 
            this.PCurrBok.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.PCurrBok.FieldDown = null;
            this.PCurrBok.FieldUp = null;
            this.PCurrBok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PCurrBok.Location = new System.Drawing.Point(67, 159);
            this.PCurrBok.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.PCurrBok.MaxError = 0;
            this.PCurrBok.MinError = 0;
            this.PCurrBok.Name = "PCurrBok";
            this.PCurrBok.NumsAfterDot = 0;
            this.PCurrBok.Size = new System.Drawing.Size(105, 23);
            this.PCurrBok.State = OmronProject.OmronEdit.TState.Norma;
            this.PCurrBok.Step = 0F;
            this.PCurrBok.TabIndex = 17;
            this.PCurrBok.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.PCurrBok.Window = OmronProject.OmronEdit.TWindow.Bok;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(178, 146);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 13);
            this.label21.TabIndex = 16;
            this.label21.Text = "%";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 146);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 13);
            this.label22.TabIndex = 15;
            this.label22.Text = "Максимум";
            // 
            // PMaxBok
            // 
            this.PMaxBok.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.PMaxBok.FieldDown = null;
            this.PMaxBok.FieldUp = null;
            this.PMaxBok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PMaxBok.Location = new System.Drawing.Point(67, 137);
            this.PMaxBok.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.PMaxBok.MaxError = 0;
            this.PMaxBok.MinError = 0;
            this.PMaxBok.Name = "PMaxBok";
            this.PMaxBok.NumsAfterDot = 0;
            this.PMaxBok.Size = new System.Drawing.Size(105, 23);
            this.PMaxBok.State = OmronProject.OmronEdit.TState.Norma;
            this.PMaxBok.Step = 0F;
            this.PMaxBok.TabIndex = 14;
            this.PMaxBok.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.PMaxBok.Window = OmronProject.OmronEdit.TWindow.Bok;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(52, 116);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(89, 18);
            this.label23.TabIndex = 13;
            this.label23.Text = "Мощность";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(178, 99);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(33, 13);
            this.label24.TabIndex = 12;
            this.label24.Text = "град.";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 99);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(55, 13);
            this.label25.TabIndex = 11;
            this.label25.Text = "Програм.";
            // 
            // TProgramBok
            // 
            this.TProgramBok.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.TProgramBok.FieldDown = null;
            this.TProgramBok.FieldUp = null;
            this.TProgramBok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TProgramBok.Location = new System.Drawing.Point(67, 92);
            this.TProgramBok.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.TProgramBok.MaxError = 0;
            this.TProgramBok.MinError = 0;
            this.TProgramBok.Name = "TProgramBok";
            this.TProgramBok.NumsAfterDot = 0;
            this.TProgramBok.Size = new System.Drawing.Size(105, 23);
            this.TProgramBok.State = OmronProject.OmronEdit.TState.Norma;
            this.TProgramBok.Step = 0F;
            this.TProgramBok.TabIndex = 10;
            this.TProgramBok.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.TProgramBok.Window = OmronProject.OmronEdit.TWindow.Bok;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(178, 73);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(33, 13);
            this.label26.TabIndex = 9;
            this.label26.Text = "град.";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(3, 73);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(47, 13);
            this.label27.TabIndex = 8;
            this.label27.Text = "Ошибка";
            // 
            // TErrorBok
            // 
            this.TErrorBok.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.TErrorBok.FieldDown = null;
            this.TErrorBok.FieldUp = null;
            this.TErrorBok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TErrorBok.Location = new System.Drawing.Point(67, 70);
            this.TErrorBok.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.TErrorBok.MaxError = 0;
            this.TErrorBok.MinError = 0;
            this.TErrorBok.Name = "TErrorBok";
            this.TErrorBok.NumsAfterDot = 0;
            this.TErrorBok.Size = new System.Drawing.Size(105, 23);
            this.TErrorBok.State = OmronProject.OmronEdit.TState.Norma;
            this.TErrorBok.Step = 0F;
            this.TErrorBok.TabIndex = 7;
            this.TErrorBok.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.TErrorBok.Window = OmronProject.OmronEdit.TWindow.Bok;
            this.TErrorBok.TextChanged += new System.EventHandler(this.OmronEdit3TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(178, 51);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(33, 13);
            this.label28.TabIndex = 6;
            this.label28.Text = "град.";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(3, 51);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(50, 13);
            this.label29.TabIndex = 5;
            this.label29.Text = "Задание";
            // 
            // TTaskBok
            // 
            this.TTaskBok.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.TTaskBok.FieldDown = null;
            this.TTaskBok.FieldUp = null;
            this.TTaskBok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TTaskBok.Location = new System.Drawing.Point(67, 44);
            this.TTaskBok.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.TTaskBok.MaxError = 0;
            this.TTaskBok.MinError = 0;
            this.TTaskBok.Name = "TTaskBok";
            this.TTaskBok.NumsAfterDot = 0;
            this.TTaskBok.Size = new System.Drawing.Size(105, 23);
            this.TTaskBok.State = OmronProject.OmronEdit.TState.Norma;
            this.TTaskBok.Step = 0F;
            this.TTaskBok.TabIndex = 4;
            this.TTaskBok.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.TTaskBok.Window = OmronProject.OmronEdit.TWindow.Bok;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.Location = new System.Drawing.Point(52, 4);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(109, 18);
            this.label30.TabIndex = 3;
            this.label30.Text = "Температура";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(178, 28);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(33, 13);
            this.label31.TabIndex = 2;
            this.label31.Text = "град.";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(3, 28);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(50, 13);
            this.label32.TabIndex = 1;
            this.label32.Text = "Останов";
            // 
            // TStopBok
            // 
            this.TStopBok.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.TStopBok.FieldDown = null;
            this.TStopBok.FieldUp = null;
            this.TStopBok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TStopBok.Location = new System.Drawing.Point(67, 25);
            this.TStopBok.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.TStopBok.MaxError = 0;
            this.TStopBok.MinError = 0;
            this.TStopBok.Name = "TStopBok";
            this.TStopBok.NumsAfterDot = 0;
            this.TStopBok.Size = new System.Drawing.Size(105, 23);
            this.TStopBok.State = OmronProject.OmronEdit.TState.Norma;
            this.TStopBok.Step = 0F;
            this.TStopBok.TabIndex = 0;
            this.TStopBok.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.TStopBok.Window = OmronProject.OmronEdit.TWindow.Bok;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.PModeDno);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.PCurrDno);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.PMaxDno);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.TProgramDno);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TErrorDno);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TTaskDno);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TStopDno);
            this.panel1.Location = new System.Drawing.Point(3, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 222);
            this.panel1.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(188, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 16);
            this.label15.TabIndex = 22;
            this.label15.Text = "Р/А";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(3, 189);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 16);
            this.label16.TabIndex = 21;
            this.label16.Text = "Режим";
            // 
            // PModeDno
            // 
            this.PModeDno.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.PModeDno.FieldDown = this.TTaskDno;
            this.PModeDno.FieldUp = this.PMaxDno;
            this.PModeDno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PModeDno.Location = new System.Drawing.Point(109, 186);
            this.PModeDno.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.PModeDno.MaxError = 0;
            this.PModeDno.MinError = 0;
            this.PModeDno.Name = "PModeDno";
            this.PModeDno.NumsAfterDot = 0;
            this.PModeDno.Size = new System.Drawing.Size(73, 23);
            this.PModeDno.State = OmronProject.OmronEdit.TState.Norma;
            this.PModeDno.Step = 0F;
            this.PModeDno.TabIndex = 20;
            this.PModeDno.Text = "Автомат";
            this.PModeDno.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.PModeDno.Window = OmronProject.OmronEdit.TWindow.Dno;
            // 
            // TTaskDno
            // 
            this.TTaskDno.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.TTaskDno.FieldDown = this.TProgramDno;
            this.TTaskDno.FieldUp = this.TStopDno;
            this.TTaskDno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TTaskDno.Location = new System.Drawing.Point(109, 47);
            this.TTaskDno.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.TTaskDno.MaxError = 0;
            this.TTaskDno.MinError = 0;
            this.TTaskDno.Name = "TTaskDno";
            this.TTaskDno.NumsAfterDot = 0;
            this.TTaskDno.Size = new System.Drawing.Size(73, 23);
            this.TTaskDno.State = OmronProject.OmronEdit.TState.Norma;
            this.TTaskDno.Step = 0F;
            this.TTaskDno.TabIndex = 4;
            this.TTaskDno.Text = "0.0";
            this.TTaskDno.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.TTaskDno.Window = OmronProject.OmronEdit.TWindow.Dno;
            // 
            // TProgramDno
            // 
            this.TProgramDno.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.TProgramDno.FieldDown = this.PMaxDno;
            this.TProgramDno.FieldUp = this.TTaskDno;
            this.TProgramDno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TProgramDno.Location = new System.Drawing.Point(109, 95);
            this.TProgramDno.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.TProgramDno.MaxError = 0;
            this.TProgramDno.MinError = 0;
            this.TProgramDno.Name = "TProgramDno";
            this.TProgramDno.NumsAfterDot = 0;
            this.TProgramDno.Size = new System.Drawing.Size(73, 23);
            this.TProgramDno.State = OmronProject.OmronEdit.TState.Norma;
            this.TProgramDno.Step = 0F;
            this.TProgramDno.TabIndex = 10;
            this.TProgramDno.Text = "0.0";
            this.TProgramDno.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.TProgramDno.Window = OmronProject.OmronEdit.TWindow.Dno;
            // 
            // PMaxDno
            // 
            this.PMaxDno.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.PMaxDno.FieldDown = this.PModeDno;
            this.PMaxDno.FieldUp = this.TProgramDno;
            this.PMaxDno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PMaxDno.Location = new System.Drawing.Point(109, 138);
            this.PMaxDno.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.PMaxDno.MaxError = 0;
            this.PMaxDno.MinError = 0;
            this.PMaxDno.Name = "PMaxDno";
            this.PMaxDno.NumsAfterDot = 0;
            this.PMaxDno.Size = new System.Drawing.Size(73, 23);
            this.PMaxDno.State = OmronProject.OmronEdit.TState.Norma;
            this.PMaxDno.Step = 0F;
            this.PMaxDno.TabIndex = 14;
            this.PMaxDno.Text = "0.0";
            this.PMaxDno.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.PMaxDno.Window = OmronProject.OmronEdit.TWindow.Dno;
            // 
            // TStopDno
            // 
            this.TStopDno.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.TStopDno.FieldDown = this.TTaskDno;
            this.TStopDno.FieldUp = this.PModeDno;
            this.TStopDno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TStopDno.Location = new System.Drawing.Point(109, 23);
            this.TStopDno.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.TStopDno.MaxError = 0;
            this.TStopDno.MinError = 0;
            this.TStopDno.Name = "TStopDno";
            this.TStopDno.NumsAfterDot = 0;
            this.TStopDno.Size = new System.Drawing.Size(73, 23);
            this.TStopDno.State = OmronProject.OmronEdit.TState.Norma;
            this.TStopDno.Step = 0F;
            this.TStopDno.TabIndex = 0;
            this.TStopDno.Text = "0.0";
            this.TStopDno.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.TStopDno.Window = OmronProject.OmronEdit.TWindow.Dno;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(188, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(3, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "Текущая";
            // 
            // PCurrDno
            // 
            this.PCurrDno.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.PCurrDno.FieldDown = this.PModeDno;
            this.PCurrDno.FieldUp = this.PMaxDno;
            this.PCurrDno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PCurrDno.Location = new System.Drawing.Point(109, 162);
            this.PCurrDno.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.PCurrDno.MaxError = 0;
            this.PCurrDno.MinError = 0;
            this.PCurrDno.Name = "PCurrDno";
            this.PCurrDno.NumsAfterDot = 0;
            this.PCurrDno.Size = new System.Drawing.Size(73, 23);
            this.PCurrDno.State = OmronProject.OmronEdit.TState.Norma;
            this.PCurrDno.Step = 0F;
            this.PCurrDno.TabIndex = 17;
            this.PCurrDno.Text = "0.0";
            this.PCurrDno.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.PCurrDno.Window = OmronProject.OmronEdit.TWindow.Dno;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(188, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(3, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Максимум";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(52, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Мощность";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(188, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "град.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Програм.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(188, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "град.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ошибка";
            // 
            // TErrorDno
            // 
            this.TErrorDno.Activity = OmronProject.OmronEdit.TActivity.ActInAct;
            this.TErrorDno.FieldDown = this.TProgramDno;
            this.TErrorDno.FieldUp = this.TTaskDno;
            this.TErrorDno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TErrorDno.Location = new System.Drawing.Point(109, 71);
            this.TErrorDno.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.TErrorDno.MaxError = 0;
            this.TErrorDno.MinError = 0;
            this.TErrorDno.Name = "TErrorDno";
            this.TErrorDno.NumsAfterDot = 0;
            this.TErrorDno.Size = new System.Drawing.Size(73, 23);
            this.TErrorDno.State = OmronProject.OmronEdit.TState.Norma;
            this.TErrorDno.Step = 0F;
            this.TErrorDno.TabIndex = 7;
            this.TErrorDno.Text = "0.0";
            this.TErrorDno.TypeContent = OmronProject.OmronEdit.TTypeContent.NumInt;
            this.TErrorDno.Window = OmronProject.OmronEdit.TWindow.Dno;
            this.TErrorDno.TextChanged += new System.EventHandler(this.OmronEdit3TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(188, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "град.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Задание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(52, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Температура";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(188, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "град.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Останов";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(992, 662);
            this.Controls.Add(this.heater1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label85);
            this.Controls.Add(this.label84);
            this.Controls.Add(this.label83);
            this.Controls.Add(this.label82);
            this.Controls.Add(this.label81);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OPanel panel1;
        private Label label15;
        private Label label16;
        private OmronEdit PModeDno;
        private Label label13;
        private Label label14;
        private OmronEdit PCurrDno;
        private Label label11;
        private Label label12;
        private OmronEdit PMaxDno;
        private Label label10;
        private Label label8;
        private Label label9;
        private OmronEdit TProgramDno;
        private Label label6;
        private Label label7;
        private OmronEdit TErrorDno;
        private Label label4;
        private Label label5;
        private OmronEdit TTaskDno;
        private Label label3;
        private Label label2;
        private Label label1;
        private OmronEdit TStopDno;
        private OPanel panel2;
        private Label label17;
        private Label label18;
        private OmronEdit PModeBok;
        private Label label19;
        private Label label20;
        private OmronEdit PCurrBok;
        private Label label21;
        private Label label22;
        private OmronEdit PMaxBok;
        private Label label23;
        private Label label24;
        private Label label25;
        private OmronEdit TProgramBok;
        private Label label26;
        private Label label27;
        private OmronEdit TErrorBok;
        private Label label28;
        private Label label29;
        private OmronEdit TTaskBok;
        private Label label30;
        private Label label31;
        private Label label32;
        private OmronEdit TStopBok;
        private OPanel panel3;
        private Label label33;
        private Label label34;
        private OmronEdit PModePit;
        private Label label35;
        private Label label36;
        private OmronEdit PCurrPit;
        private Label label37;
        private Label label38;
        private OmronEdit PMaxPit;
        private Label label39;
        private Label label40;
        private Label label41;
        private OmronEdit TProgramPit;
        private Label label42;
        private Label label43;
        private OmronEdit TErrorPit;
        private Label label44;
        private Label label45;
        private OmronEdit TTaskPit;
        private Label label46;
        private Label label47;
        private Label label48;
        private OmronEdit TStopPit;
        private OPanel panel4;
        private Label label49;
        private Label label50;
        private OmronEdit PModeAlg;
        private Label label51;
        private Label label52;
        private OmronEdit PCurrAlg;
        private Label label53;
        private Label label54;
        private OmronEdit PMaxAlg;
        private Label label55;
        private Label label56;
        private Label label57;
        private OmronEdit TProgramAlg;
        private Label label58;
        private Label label59;
        private OmronEdit TErrorAlg;
        private Label label60;
        private Label label61;
        private OmronEdit TTaskAlg;
        private Label label62;
        private Label label63;
        private Label label64;
        private OmronEdit TStopAlg;
        private DataGridView dataGridView1;
        private OPanel panel5;
        private Label label65;
        private Label label66;
        private OmronEdit omronEdit29;
        private Label label67;
        private Label label68;
        private OmronEdit omronEdit30;
        private Label label69;
        private Label label70;
        private OmronEdit omronEdit31;
        private Label label71;
        private Label label72;
        private Label label73;
        private OmronEdit omronEdit32;
        private Label label74;
        private Label label75;
        private OmronEdit omronEdit33;
        private Label label76;
        private Label label77;
        private OmronEdit omronEdit34;
        private Label label78;
        private Label label79;
        private Label label80;
        private OmronEdit omronEdit35;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TextBox textBox1;
        private Label label81;
        private Label label82;
        private Label label83;
        private Label label84;
        private Label label85;
        private Chart chart1;
        private Heater heater1;

    }
}
