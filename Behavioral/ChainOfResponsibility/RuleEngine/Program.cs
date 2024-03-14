using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Abstractions;
using Thisisnabi.DesignPattern.Behavioral.ChainOfResponsibility.RuleEngine.Rules;

IRule rule1 = new Rule1();
IRule rule2 = new Rule2();

rule1.NextRule = rule2;

// Execute the chain of rules against your input data.
RuleHandler handler = new RuleHandler(rule1);
handler.Execute(new object()); // Pass your input data here