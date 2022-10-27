using Caliburn.Micro;
using Gloomath.Extensions;
using Gloomath.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gloomath.ViewModels.Practices
{
    public class StartedPracticeViewModel : Screen
    {
        private List<QuestionOption> SelectedQuestionOptions = new List<QuestionOption>();
        private PracticeConfig PracticeConfig;
        private SectionViewModel SectionViewModel;
        private DateTime StartTime = DateTime.Now;

        private PracticeProgress _practiceProgress = new PracticeProgress();
        public PracticeProgress PracticeProgress
        {
            get
            {
                return _practiceProgress;
            }
            set
            {
                _practiceProgress = value;
                NotifyOfPropertyChange(() => PracticeProgress);
            }
        }

        private Question _currentQuestion;
        public Question CurrentQuestion
        {
            get
            {
                return _currentQuestion;
            }
            set
            {
                _currentQuestion = value;
                NotifyOfPropertyChange(() => CurrentQuestion);
            }
        }

        private BindableCollection<Question> _questions;
        public BindableCollection<Question> Questions
        {
            get
            {
                return _questions;
            }
            set
            {
                _questions = value;
                NotifyOfPropertyChange(() => Questions);
            }
        }

        private int _currentQuestionIndex;
        public int CurrentQuestionIndex
        {
            get
            {
                return _currentQuestionIndex;
            }
            set
            {
                _currentQuestionIndex = value;
                NotifyOfPropertyChange(() => CurrentQuestionIndex);
            }
        }

        private QuestionOption _selectedQuestionOptionInput;
        public QuestionOption SelectedQuestionOptionInput
        {
            get
            {
                return _selectedQuestionOptionInput;
            }
            set
            {
                _selectedQuestionOptionInput = value;
                NotifyOfPropertyChange(() => SelectedQuestionOptionInput);
            }
        }

        public StartedPracticeViewModel(SectionViewModel sectionViewModel, PracticeConfig practiceConfig)
        {
            this.PracticeConfig = practiceConfig;
            this.SectionViewModel = sectionViewModel;

            SectionViewModel.Content.Section.PracticeTopic.Questions.Shuffle();

            List<Question> questions = new List<Question>();
            FilterQuestionsFromPracticeConfig(questions);

            Questions = new BindableCollection<Question>(questions);

            CurrentQuestion = Questions[CurrentQuestionIndex];

            PracticeProgress.CurrentQuestion = CurrentQuestionIndex + 1;
            PracticeProgress.MaxQuestionsQuantity = Questions.Count;

            MapCurrentQuestionOptionsSymbols();
        }

        private void FilterQuestionsFromPracticeConfig(List<Question> questions)
        {
            int maxQuestionsCounter = 0;

            foreach (Question question in SectionViewModel.Content.Section.PracticeTopic.Questions)
            {
                if (maxQuestionsCounter == PracticeConfig.QuestionsQuantity) break;
                if (question.Difficulty != PracticeConfig.SelectedDifficulty) continue;

                maxQuestionsCounter++;
                questions.Add(question);
            }
        }

        public void Select(QuestionOption questionOption)
        {
            SelectedQuestionOptionInput = questionOption;
            NotifyOfPropertyChange(() => CanProceed);
        }

        public bool CanProceed => SelectedQuestionOptionInput is not null;
        public void Proceed()
        {
            AddSelectedQuestionOptionInput();

            if (CurrentQuestionIndex + 1 >= Questions.Count)
            {
                ShellViewModel shellViewModel = IoC.Get<ShellViewModel>();

                int correctQuestions = SelectedQuestionOptions.Where(questionOption => questionOption.IsCorrect).Count();
                int wrongQuestions = SelectedQuestionOptions.Where(questionOption => !questionOption.IsCorrect).Count();

                int correctQuestionsPercentageValue = (int)((double)correctQuestions / (double)SelectedQuestionOptions.Count * 100d);
                int wrongQuestionsPercentageValue = (int)((double)wrongQuestions / (double)SelectedQuestionOptions.Count * 100d);

                PracticeResult result = new PracticeResult()
                {
                    StartTime = StartTime,
                    EndTime = Convert.ToDateTime((DateTime.Now - StartTime).ToString()),
                    PracticeConfig = PracticeConfig,
                    QuestionOptions = SelectedQuestionOptions,
                    CorrectQuestions = correctQuestions,
                    WrongQuestions = wrongQuestions,
                    CorrectQuestionsPercentage = correctQuestionsPercentageValue,
                    WrongQuestionsPercentage = wrongQuestionsPercentageValue
                };

                shellViewModel.ActivateItemAsync(new FinalPracticeResultViewModel(SectionViewModel, result));
                return;
            }

            CurrentQuestion = Questions[++CurrentQuestionIndex];
            Update();
        }

        private void AddSelectedQuestionOptionInput()
        {
            SelectedQuestionOptions.Add(SelectedQuestionOptionInput);
            SelectedQuestionOptionInput = null;
        }

        private void Update()
        {
            PracticeProgress.CurrentQuestion = CurrentQuestionIndex + 1;
            MapCurrentQuestionOptionsSymbols();
            NotifyOfPropertyChange(() => CanProceed);
            NotifyOfPropertyChange(() => PracticeProgress);
        }

        private void MapCurrentQuestionOptionsSymbols()
        {
            for (int i = 0; i < CurrentQuestion.Options.Count; i++)
            {
                QuestionOption questionOption = CurrentQuestion.Options[i];

                questionOption.Symbol = (char)(65 + i);
            }
        }
    }
}