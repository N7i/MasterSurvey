using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MasterSurvey.Core.Interfaces;
using MasterSurvey.Core;
using MasterSurvey.Ext.FreeQuestion;

namespace MasterSurvey.Tests
{
    [TestFixture]
    public class FormTests
    {
        [TestCase]
        public void CreateEmptyForm()
        {
            // Arrange
            IForm myForm = new MilitaryForm();

            // Act

            // Assert
            Assert.That(myForm.Title, Is.Empty);
            Assert.That(myForm.Answers, Is.Empty);
        }

        [TestCase]
        public void AddFormQuestions() 
        {
            // Arrange
            IForm myForm = new MilitaryForm();

            // Act 
            IQuestion myFirstQuestion = myForm.Questions.AddNew(typeof(FreeQuestion));
            IQuestion mySecondQuestion = myForm.Questions.AddNew(typeof(FreeQuestion));
            
            // Assert
            Assert.That(myForm.Questions.Count, Is.EqualTo(2));


        }

        [TestCase]
        public void FindOrCreateFormAnwser()
        {
            // Arrange
            IForm myForm = new MilitaryForm();

            // Act
            IReadOnlyDictionary<string, IFormAnswer> answers = myForm.Answers;
            IFormAnswer myAnwser = myForm.FindOrCreateAnswerFor("cobaye");
            IFormAnswer theSameAnswer = myForm.FindOrCreateAnswerFor("cobaye");

            // Assert
            Assert.That(answers.ContainsKey("cobaye"), Is.True);
            Assert.That(myAnwser, Is.Not.Null);
            Assert.That(myAnwser, Is.EqualTo(theSameAnswer));
        }

        [TestCase]
        public void SerializeAndUnSerializeForm()
        {
            throw new NotImplementedException();
        }
    }
}
