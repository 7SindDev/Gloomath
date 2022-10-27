using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gloomath.Models
{
    public class PracticeConfig
    {
        public bool IsQuestionsVaried { get; set; }
        public bool RevealCorrectAlternativesAfterSelectionConfirmation { get; set; }
        public DifficultiesKind SelectedDifficulty { get; set; } = DifficultiesKind.Easy;
        public int QuestionsQuantity { get; set; } = 1;
    }
}
