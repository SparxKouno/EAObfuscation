using System.Collections.Generic;

namespace EAObfuscation
{
    internal class Rules
    {
        private List<Rule> _ruleList = new List<Rule>();

        public enum RuleCategory
        {
            Pacakge_Name = 0,
            Element,
            Attribute,
            Operation,
            Connector_Name,
            Diagram_Name,
            Requirement_Constraints,
            Testing,
            Maintenance,
            System,
            Element_Note,
            Connector_Note,
            Attribute_Note,
            Operation_Note,
            Diagram_Note,
            Author,
            Flow_Transition
        }

        public static string[] RuleCategoryDescriptions =
        {
            "Change Package Names",
            "Change Element Names",
            "Change Attribute Names",
            "Change Operation names",
            "Change Connector Names and Role Names",
            "Change Diagram Names",
            "Remove Element Requirements, Constraints and Scenarios",
            "Remove Element Tests",
            "Remove Element Maintenance Items",
            "Remove Project Glossary, Issues and Tasks",
            "Clear Element Notes",
            "Clear Connector Notes",
            "Clear Attribute Notes",
            "Clear Operation Notes",
            "Clear Diagram Notes",
            "Clear Author Fields",
            "Remove Flow and Transition Conditions"
        };

        public Rules()
        {
            //Pacakge name
            _ruleList.Add(new Rule(RuleCategory.Pacakge_Name, "t_package SET Name='Pack:' & Package_ID"));
            //Element
            _ruleList.Add(new Rule(RuleCategory.Element, "t_object SET Name = 'Elem:' & Object_ID"));
            _ruleList.Add(new Rule(RuleCategory.Element, "t_object SET Alias='Alias:' & Object_ID WHERE Alias <> ''"));
            _ruleList.Add(new Rule(RuleCategory.Element, "t_object SET GenFile='(deleted)' WHERE GenFile <> ''"));
            _ruleList.Add(new Rule(RuleCategory.Element, "t_attribute SET Type='Type:' & ID"));
            _ruleList.Add(new Rule(RuleCategory.Element, "t_attribute SET Type='Elem:' & Classifier WHERE Classifier <> ''"));
            _ruleList.Add(new Rule(RuleCategory.Element, "t_operation SET Type='Elem:' & Classifier WHERE Classifier <> ''"));
            _ruleList.Add(new Rule(RuleCategory.Element, "t_operationparams SET Type='Elem:' & Classifier WHERE Classifier <> ''"));
            _ruleList.Add(new Rule(RuleCategory.Element, "t_objectproperties SET [Value]='<deleted/>' WHERE [Value] <> ''"));
            _ruleList.Add(new Rule(RuleCategory.Element, "t_objectproperties SET Notes='<deleted/>' WHERE Notes <> ''"));
            //Attribute
            _ruleList.Add(new Rule(RuleCategory.Attribute, "t_attribute SET Name='Attr:' & ID"));
            _ruleList.Add(new Rule(RuleCategory.Attribute, "t_attribute SET Style='Alias:' & ID WHERE Style <> ''"));
            _ruleList.Add(new Rule(RuleCategory.Attribute, "t_attribute SET Container='(deleted)' WHERE Container <> ''"));
            _ruleList.Add(new Rule(RuleCategory.Operation, "t_attributetag SET [VALUE]='(deleted)' WHERE [VALUE] <> ''"));
            //Operation
            _ruleList.Add(new Rule(RuleCategory.Operation, "t_operation SET Name='Ope:' & OperationID, Type='Type:' & OperationID"));
            _ruleList.Add(new Rule(RuleCategory.Operation, "t_operation SET Style='Alias:' & OperationID WHERE Style <> ''"));
            _ruleList.Add(new Rule(RuleCategory.Operation, "t_operationparams SET Name='Para:'  & Pos"));
            _ruleList.Add(new Rule(RuleCategory.Operation, "t_operationparams SET StyleEx=''"));
            _ruleList.Add(new Rule(RuleCategory.Operation, "t_connector SET PDATA2=null WHERE NOT PDATA2 = 'retval=void;'"));
            _ruleList.Add(new Rule(RuleCategory.Operation, "t_operation SET Code='(deleted)' WHERE Code <> ''"));
            _ruleList.Add(new Rule(RuleCategory.Operation, "t_operationtag SET [VALUE]='(deleted)' WHERE [VALUE] <> '' AND Property <> 'ea_guid'"));
            _ruleList.Add(new Rule(RuleCategory.Operation, "t_taggedvalue SET Notes='(deleted)' WHERE Notes <> '' AND BaseClass = 'OPERATION_PARAMETER'"));
            //Connector name
            _ruleList.Add(new Rule(RuleCategory.Connector_Name, "t_connector SET Name='Conn:' & Connector_ID WHERE Name IS NOT NULL"));
            _ruleList.Add(new Rule(RuleCategory.Connector_Name, "t_connector SET DestRole='ConnD:' & Connector_ID WHERE DestRole IS NOT NULL"));
            _ruleList.Add(new Rule(RuleCategory.Connector_Name, "t_connector SET SourceRole='ConnS:' & Connector_ID WHERE SourceRole IS NOT NULL"));
            //Diagram name
            _ruleList.Add(new Rule(RuleCategory.Diagram_Name, "t_diagram SET Name='Diag:' & Diagram_ID"));
            //Requirement AND Constraints
            _ruleList.Add(new Rule(RuleCategory.Requirement_Constraints, "t_attributeconstraints"));
            _ruleList.Add(new Rule(RuleCategory.Requirement_Constraints, "t_connectorconstraint"));
            _ruleList.Add(new Rule(RuleCategory.Requirement_Constraints, "t_objectconstraint"));
            _ruleList.Add(new Rule(RuleCategory.Requirement_Constraints, "t_objectrequires"));
            _ruleList.Add(new Rule(RuleCategory.Requirement_Constraints, "t_objectscenarios"));
            _ruleList.Add(new Rule(RuleCategory.Requirement_Constraints, "t_operationpres"));
            _ruleList.Add(new Rule(RuleCategory.Requirement_Constraints, "t_operationposts"));
            _ruleList.Add(new Rule(RuleCategory.Requirement_Constraints, "t_roleconstraint"));
            //Testing
            _ruleList.Add(new Rule(RuleCategory.Testing, "t_objecttests"));
            //Maintenance
            _ruleList.Add(new Rule(RuleCategory.Maintenance, "t_objecteffort"));
            _ruleList.Add(new Rule(RuleCategory.Maintenance, "t_objectproblems"));
            _ruleList.Add(new Rule(RuleCategory.Maintenance, "t_objectrisks"));
            //System
            _ruleList.Add(new Rule(RuleCategory.System, "t_glossary"));
            _ruleList.Add(new Rule(RuleCategory.System, "t_issues"));
            _ruleList.Add(new Rule(RuleCategory.System, "t_tasks"));
            //Element note
            _ruleList.Add(new Rule(RuleCategory.Element_Note, "t_object SET [Note]='(deleted)' WHERE [Note] IS NOT NULL"));
            _ruleList.Add(new Rule(RuleCategory.Element_Note, "t_package SET Notes='(deleted)' WHERE Notes IS NOT NULL"));
            //Connector note
            _ruleList.Add(new Rule(RuleCategory.Connector_Note, "t_connector SET Notes='(deleted)' WHERE Notes IS NOT NULL"));
            _ruleList.Add(new Rule(RuleCategory.Connector_Note, "t_connector SET SourceRoleNote='(deleted)' WHERE SourceRoleNote IS NOT NULL"));
            _ruleList.Add(new Rule(RuleCategory.Connector_Note, "t_connector SET DestRoleNote='(deleted)' WHERE DestRoleNote IS NOT NULL"));
            //Attribute note
            _ruleList.Add(new Rule(RuleCategory.Attribute_Note, "t_attribute SET Notes='(deleted)' WHERE Notes IS NOT NULL"));
            //Operation note
            _ruleList.Add(new Rule(RuleCategory.Operation_Note, "t_operation SET Notes = '(deleted)' WHERE Notes IS NOT NULL"));
            _ruleList.Add(new Rule(RuleCategory.Operation_Note, "t_operationparams SET Notes='(deleted)' WHERE Notes IS NOT NULL"));
            //Diagram note
            _ruleList.Add(new Rule(RuleCategory.Diagram_Note, "t_diagram SET Notes='(deleted)' WHERE Notes IS NOT NULL"));
            //Author
            _ruleList.Add(new Rule(RuleCategory.Author, "t_authors SET AuthorName = '(deleted)'"));
            _ruleList.Add(new Rule(RuleCategory.Author, "t_object SET Author='(deleted)' WHERE Author IS NOT NULL"));
            _ruleList.Add(new Rule(RuleCategory.Author, "t_diagram SET Author='(deleted)' WHERE Author IS NOT NULL"));
            _ruleList.Add(new Rule(RuleCategory.Author, "t_document SET Author='(deleted)' WHERE Author IS NOT NULL"));
            _ruleList.Add(new Rule(RuleCategory.Author, "t_script SET ScriptAuthor='(deleted)' WHERE ScriptAuthor IS NOT NULL"));
            _ruleList.Add(new Rule(RuleCategory.Author, "t_testplans SET Author='(deleted)' WHERE Author IS NOT NULL"));
            //Flow and Transition
            _ruleList.Add(new Rule(RuleCategory.Flow_Transition, "t_connector SET PDATA1='(deleted)' WHERE Connector_Type='StateFlow' AND PDATA1 IS NOT NULL"));
            _ruleList.Add(new Rule(RuleCategory.Flow_Transition, "t_connector SET PDATA2='(deleted)' WHERE Connector_Type='StateFlow' AND PDATA2 IS NOT NULL"));
            _ruleList.Add(new Rule(RuleCategory.Flow_Transition, "t_connector SET PDATA2='(deleted)' WHERE Connector_Type='ControlFlow' AND PDATA2 IS NOT NULL"));
            _ruleList.Add(new Rule(RuleCategory.Flow_Transition, "t_connector SET PDATA2='(deleted)' WHERE Connector_Type='ObjectFlow' AND PDATA2 IS NOT NULL"));
        }

        public IEnumerable<string> GetSQL(Rules.RuleCategory category)
        {
            foreach (Rule rule in _ruleList)
            {
                if (!rule.HasID(category))
                {
                    continue;
                }

                yield return rule.GetSQL();
            }
        }
    }
}
