using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace EAObfuscation
{
    internal class Obfuscation
    {
        private EA.Repository _repository;
        private string _targetFilePath;
        private string _obfuscatedFilePath;

        public Obfuscation(string filePath)
        {
            _repository = new EA.Repository();
            _targetFilePath = filePath;
        }

        private bool BackupFile()
        {
            try
            {
                string directoryName = Path.GetDirectoryName(_targetFilePath);
                string bodyName = Path.GetFileNameWithoutExtension(_targetFilePath);
                string extension = Path.GetExtension(_targetFilePath);

                _obfuscatedFilePath = $"{directoryName}\\{bodyName}_obfuscated{extension}";
                File.Copy(_targetFilePath, _obfuscatedFilePath);

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"{Properties.Resources.MSG_CANTCOPY}\n{e.Message}");
                return false;
            }
        }

        public bool Execute(List<bool> target)
        {
            if (!BackupFile())
            {
                return false;
            }

            if (!_repository.OpenFile(_obfuscatedFilePath))
            {
                MessageBox.Show(Properties.Resources.MSG_CANTOPEN);
                return false;
            }

            Rules rules = new Rules();

            try
            {
                foreach(Rules.RuleCategory category in Enum.GetValues(typeof(Rules.RuleCategory)))
                {
                    if (!target[(int)category])
                    {
                        continue;
                    }

                    foreach (string sql in rules.GetSQL(category))
                    {
                        _repository.Execute(sql);
                    }
                }

                MessageBox.Show(Properties.Resources.MSG_FINISHED);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show($"{Properties.Resources.MSG_ERROR}\n{e.Message}");
                return false;
            }
            finally
            {
                _repository.CloseFile();
                _repository.Exit();
            }
        }
    }
}
