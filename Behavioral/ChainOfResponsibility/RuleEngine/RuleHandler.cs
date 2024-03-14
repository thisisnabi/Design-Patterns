using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Abstractions;

namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine
{
    public class RuleHandler(IRule firstRule)
    {
        private readonly IRule _firstRule = firstRule;

        public void Execute(object data)
        {
            _firstRule.ApplyRule(data);
        }
    }
}
