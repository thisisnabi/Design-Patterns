namespace Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Abstractions
{
    public interface IRule
    {
        void ApplyRule(object data);
        IRule? NextRule { get; set; } // NextRule property for chaining rules
    }
}
