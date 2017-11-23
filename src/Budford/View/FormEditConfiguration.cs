﻿using Budford.Model;
using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;

namespace Budford
{
    public partial class FormEditConfiguration : Form
    {
        // Our config settings
        readonly Model.Model model;

        readonly Settings settings;

        List<string> removedFolders = new List<string>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="settingsIn"></param>
        public FormEditConfiguration(Model.Model modelIn, int modeIn)
        {
            InitializeComponent();
            model = modelIn;
            settings = model.Settings;

            foreach (var folder in settings.RomFolders)
            {
                listView1.Items.Add(folder);
            }
            checkBox1.Checked = settings.DisableShaderCache;
            checkBox2.Checked = settings.ForceLowResolutionGraphicsPacks;

            radioButton1.Checked = settings.DefaultResolution == "2160p";
            radioButton2.Checked = settings.DefaultResolution == "1800p";
            radioButton3.Checked = settings.DefaultResolution == "1440p";
            radioButton4.Checked = settings.DefaultResolution == "1080p";

            radioButton5.Checked = settings.DefaultResolution == "540p";
            radioButton6.Checked = settings.DefaultResolution == "360p";

            radioButton7.Checked = settings.DefaultResolution == "default";

            if (modeIn == 1)
            {
                tabControl1.SelectTab(1);
            }
            else if (modeIn == 2)
            {
                tabControl1.SelectTab(2);
            }

            comboBox2.SelectedIndex = (int)settings.ConsoleLanguage;
            switch (settings.ConsoleRegion)
            {
                case Settings.ConsoleRegionType.Auto:
                    comboBox1.SelectedIndex = 0;
                    break;
                case Settings.ConsoleRegionType.JAP:
                    comboBox1.SelectedIndex = 1;
                    break;
                case Settings.ConsoleRegionType.USA:
                    comboBox1.SelectedIndex = 2;
                    break;
                case Settings.ConsoleRegionType.EUR:
                    comboBox1.SelectedIndex = 3;
                    break;
                case Settings.ConsoleRegionType.China:
                    comboBox1.SelectedIndex = 4;
                    break;
                case Settings.ConsoleRegionType.Korea:
                    comboBox1.SelectedIndex = 5;
                    break;
                case Settings.ConsoleRegionType.Taiwan:
                    comboBox1.SelectedIndex = 6;
                    break;                
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    listView1.Items.Add(fbd.SelectedPath);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView1.SelectedItems)
            {
                removedFolders.Add(lvi.Text);
                listView1.Items.Remove(lvi);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {           
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(CancelEventArgs e)
        {
            settings.RomFolders.Clear();
            foreach (ListViewItem item in listView1.Items)
            {
                settings.RomFolders.Add(item.Text);
            }

            HandleRemovedFolder();

            if (radioButton1.Checked) settings.DefaultResolution = "2160p";
            if (radioButton2.Checked) settings.DefaultResolution = "1800p";
            if (radioButton3.Checked) settings.DefaultResolution = "1440p";
            if (radioButton4.Checked) settings.DefaultResolution = "1080p";
            if (radioButton5.Checked) settings.DefaultResolution = "540p";
            if (radioButton6.Checked) settings.DefaultResolution = "360p";
            if (radioButton7.Checked) settings.DefaultResolution = "default";

            settings.ConsoleLanguage = (Settings.ConsoleLanguageType)comboBox2.SelectedIndex;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    settings.ConsoleRegion = Settings.ConsoleRegionType.Auto;
                    break;
                case 1:
                    settings.ConsoleRegion = Settings.ConsoleRegionType.JAP;
                    break;
                case 2:
                    settings.ConsoleRegion = Settings.ConsoleRegionType.USA;
                    break;
                case 3:
                    settings.ConsoleRegion = Settings.ConsoleRegionType.EUR;
                    break;
                case 4:
                    settings.ConsoleRegion = Settings.ConsoleRegionType.China;
                    break;
                case 5:
                    settings.ConsoleRegion = Settings.ConsoleRegionType.Korea;
                    break;
                case 6:
                    settings.ConsoleRegion = Settings.ConsoleRegionType.Taiwan;
                    break;
            }

            base.OnClosing(e);
        }

        /// <summary>
        /// 
        /// </summary>
        private void HandleRemovedFolder()
        {
            List<string> keysToRemove = new List<string>();
            foreach (var game in model.GameData)
            {
                foreach (var removedFolder in removedFolders)
                {
                    if (game.Value.LaunchFile.Contains(removedFolder))
                    {
                        keysToRemove.Add(game.Key);
                    }
                }
            }

            foreach (var key in keysToRemove)
            {
                model.GameData.Remove(key);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            settings.DisableShaderCache = checkBox1.Checked;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            settings.ForceLowResolutionGraphicsPacks = checkBox2.Checked;
        }
    }
}