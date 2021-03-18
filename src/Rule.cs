namespace EAObfuscation
{
    internal class Rule
    {
        private Rules.RuleCategory _ruleCategory;
        private string _ruleSQL = "";
        private string _deleteTableName = "";

        public Rule(Rules.RuleCategory category, string sqlOrTableName)
        {
            _ruleCategory = category;

            if (sqlOrTableName.Contains(" "))
            {
                _ruleSQL = sqlOrTableName;
            }
            else
            {
                _deleteTableName = sqlOrTableName;
            }
        }

        public bool HasID(Rules.RuleCategory category)
        {
            return (_ruleCategory == category);
        }

        public string GetSQL()
        {
            if (_deleteTableName != "")
            {
                return $"DELETE FROM {_deleteTableName}";
            }

            return $"UPDATE {_ruleSQL}";
        }
    }
}
