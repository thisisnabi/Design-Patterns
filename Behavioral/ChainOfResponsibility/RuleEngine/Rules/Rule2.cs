using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Abstractions;

namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Rules
{
    public class Rule2 : IRule
    {
        public IRule? NextRule { get; set; }

        public void ApplyRule(object data)
        {
            Console.WriteLine("Rule 2 applied");
            // Implement rule logic here

            // Call the next rule if it exists
            NextRule?.ApplyRule(data);
        }
    }
}
