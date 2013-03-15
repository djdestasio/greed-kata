using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shouldly;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace GreedKata.Specs
{
    [Binding]
    public class DiceRollerSteps
    {
        private IDiceRollScorer _diceRollScorer;
        private IList<int> _roll; 
        private int _score; 
        
        [Given(@"that I have a roll scorer")]
        public void GivenThatIHaveARollScorer()
        {
            _diceRollScorer = new DiceRollScorer();
        }

        [Given(@"that I have rolled the following values")]
        public void GivenThatIHaveRolledTheFollowingValues(Table table)
        {
            _roll = new List<int>();

            foreach (var row in table.Rows)
            {
                _roll.Add(int.Parse(row["Value"]));
            }
        }

        [When(@"I score the roll")]
        public void WhenIScoreTheRoll()
        {
            try
            {
                _score = _diceRollScorer.Score(_roll);
            }
            catch(ArgumentException ae)
            {
                ScenarioContext.Current.Set<ArgumentException>(ae, "Too_Many_Dice_Error");
            }
        }

        [Then(@"the score should be (.*)")]
        public void ThenTheScoreShouldBe(int p0)
        {
            _score.ShouldBe(p0);
        }

        [Then(@"an argument exception should be thrown")]
        public void ThenAnArgumentExceptionShouldBeThrown()
        {
            ScenarioContext.Current.Get<ArgumentException>("Too_Many_Dice_Error").ShouldNotBe(null);
        }

    }
}
