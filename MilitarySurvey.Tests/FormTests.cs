using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MilitarySurvey.Core.Interfaces;
using MilitarySurvey.Core;
using MilitarySurvey.Ext.OpenQuestion;

namespace MilitarySurvey.Tests
{
    [TestFixture]
    public class FormTests
    {
        [TestCase]
        public void CreateEmptyForm()
        {
            // Arrange
            IForm myForm = new QuestionGroup();

            // Act

            // Assert
            Assert.That(myForm.Title, Is.Empty);
            Assert.That(myForm.Answers, Is.Empty);
        }

        [TestCase]
        public void AddFormQuestions() 
        {
            // Arrange
            IForm myForm = new QuestionGroup();

            // Act 
            IQuestionInfo myFirstQuestion = myForm.Questions.AddNew(typeof(OpenQuestion));
            IQuestionInfo mySecondQuestion = myForm.Questions.AddNew(typeof(OpenQuestion));
            
            // Assert
            Assert.That(myForm.Questions.Count, Is.EqualTo(2));


        }

        [TestCase]
        public void FindOrCreateFormAnwser()
        {
            // Arrange
            IForm myForm = new QuestionGroup();

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
