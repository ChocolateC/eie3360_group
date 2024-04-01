using UnityEngine;

public class QuizDataInitializer : MonoBehaviour
{
    public QuizData quizData;

    void Start()
    {
        if (quizData == null)
        {
            Debug.LogError("QuizData asset is not assigned!");
            return;
        }

        // Initialize the questions array
        quizData.questions = new QuizData.QuizQuestion[30];


        // Question 1
        quizData.questions[0] = new QuizData.QuizQuestion();
        quizData.questions[0].questionText = "When did Christopher Columbus set sail on his first voyage across the Atlantic Ocean?";
        quizData.questions[0].answerOptions = new string[] { "1492", "1498", "1502", "1510" };
        quizData.questions[0].correctAnswerIndex = 0;

        // Question 2
        quizData.questions[1] = new QuizData.QuizQuestion();
        quizData.questions[1].questionText = "What was the name of the ship Columbus captained during his first voyage?";
        quizData.questions[1].answerOptions = new string[] { "Santa Maria", "Nina", "Pinta", "Victoria" };
        quizData.questions[1].correctAnswerIndex = 0;

        // Question 3
        quizData.questions[2] = new QuizData.QuizQuestion();
        quizData.questions[2].questionText = "Which country sponsored Columbus's voyages to find a western sea route to Asia?";
        quizData.questions[2].answerOptions = new string[] { "Spain", "Portugal", "England", "France" };
        quizData.questions[2].correctAnswerIndex = 0;

        // Question 4
        quizData.questions[3] = new QuizData.QuizQuestion();
        quizData.questions[3].questionText = "Which island in the Bahamas did Columbus first land on during his first voyage?";
        quizData.questions[3].answerOptions = new string[] { "San Salvador", "Jamaica", "Cuba", "Hispaniola" };
        quizData.questions[3].correctAnswerIndex = 0;

        // Question 5
        quizData.questions[4] = new QuizData.QuizQuestion();
        quizData.questions[4].questionText = "What was the name of the indigenous people Columbus encountered in the Caribbean?";
        quizData.questions[4].answerOptions = new string[] { "Taino", "Aztecs", "Mayans", "Incas" };
        quizData.questions[4].correctAnswerIndex = 0;

        // Question 6
        quizData.questions[5] = new QuizData.QuizQuestion();
        quizData.questions[5].questionText = "What were the main objectives of Columbus's voyages?";
        quizData.questions[5].answerOptions = new string[] { "Find a sea route to India", "Spread Christianity", "Discover new lands", "All of the above" };
        quizData.questions[5].correctAnswerIndex = 3;

        // Question 7
        quizData.questions[6] = new QuizData.QuizQuestion();
        quizData.questions[6].questionText = "What was the name of the agreement between Spain and Portugal that divided newly discovered lands outside Europe?";
        quizData.questions[6].answerOptions = new string[] { "Treaty of Tordesillas", "Treaty of Versailles", "Treaty of Madrid", "Treaty of Seville" };
        quizData.questions[6].correctAnswerIndex = 0;

        // Question 8
        quizData.questions[7] = new QuizData.QuizQuestion();
        quizData.questions[7].questionText = "During which voyage did Columbus reach the mainland of South America?";
        quizData.questions[7].answerOptions = new string[] { "First voyage", "Second voyage", "Third voyage", "Fourth voyage" };
        quizData.questions[7].correctAnswerIndex = 1;

        // Question 9
        quizData.questions[8] = new QuizData.QuizQuestion();
        quizData.questions[8].questionText = "What was the term Columbus used to describe the indigenous people he encountered, mistakenly believing he had reached India?";
        quizData.questions[8].answerOptions = new string[] { "Indians", "Natives", "Africans", "Asians" };
        quizData.questions[8].correctAnswerIndex = 0;

        // Question 10
        quizData.questions[9] = new QuizData.QuizQuestion();
        quizData.questions[9].questionText = "What was the main motivation for European exploration during Columbus's time?";
        quizData.questions[9].answerOptions = new string[] { "Economic wealth", "Religious conversion", "Scientific curiosity", "Political power" };
        quizData.questions[9].correctAnswerIndex = 3;

        // Question 11
        quizData.questions[10] = new QuizData.QuizQuestion();
        quizData.questions[10].questionText = "What was the name of Columbus's son who accompanied him on his fourth voyage?";
        quizData.questions[10].answerOptions = new string[] { "Diego", "Ferdinand", "Bartolomeo", "Alonso" };
        quizData.questions[10].correctAnswerIndex = 0;

        // Question 12
        quizData.questions[11] = new QuizData.QuizQuestion();
        quizData.questions[11].questionText = "What was the name of the settlement Columbus established on his second voyage in present-day Dominican Republic?";
        quizData.questions[11].answerOptions = new string[] { "Santo Domingo", "San Salvador", "Santa Fe", "San Juan" };
        quizData.questions[11].correctAnswerIndex = 0;

        // Question 13
        quizData.questions[12] = new QuizData.QuizQuestion();
        quizData.questions[12].questionText = "Which of the following items were NOT brought back to Europe by Columbus after his first voyage?";
        quizData.questions[12].answerOptions = new string[] { "Tobacco", "Potatoes", "Tomatoes", "Gold" };
        quizData.questions[12].correctAnswerIndex = 0;

        // Question 14
        quizData.questions[13] = new QuizData.QuizQuestion();
        quizData.questions[13].questionText = "What was the name of the ocean that Columbus crossed during his voyages to the Americas?";
        quizData.questions[13].answerOptions = new string[] { "Atlantic Ocean", "Pacific Ocean", "Indian Ocean", "Arctic Ocean" };
        quizData.questions[13].correctAnswerIndex = 0;

        // Question 15
        quizData.questions[14] = new QuizData.QuizQuestion();
        quizData.questions[14].questionText = "What was the primary reason why Columbus's voyages are significant in history?";
        quizData.questions[14].answerOptions = new string[] { "They led to the discovery of the Americas", "They initiated European exploration and colonization of the New World", "They opened up global trade routes", "All of the above" };
        quizData.questions[14].correctAnswerIndex = 3;

        // Question 16
        quizData.questions[15] = new QuizData.QuizQuestion();
        quizData.questions[15].questionText = "What was the name of the expedition that Columbus led in 1492?";
        quizData.questions[15].answerOptions = new string[] { "The Enterprise of the Indies", "The First Expedition", "The Discovery of the New World", "The Voyage of the Santa Maria" };
        quizData.questions[15].correctAnswerIndex = 0;


        // Question 17
        quizData.questions[16] = new QuizData.QuizQuestion();
        quizData.questions[16].questionText = "Which European country initially rejected Columbus's proposal before Spain sponsored his voyages?";
        quizData.questions[16].answerOptions = new string[] { "Italy", "France", "Portugal", "England" };
        quizData.questions[16].correctAnswerIndex = 2;

        // Question 18
        quizData.questions[17] = new QuizData.QuizQuestion();
        quizData.questions[17].questionText = "What was the name of the indigenous leader who welcomed Columbus on his first voyage?";
        quizData.questions[17].answerOptions = new string[] { "Guacanagari", "Montezuma", "Atahualpa", "Pocahontas" };
        quizData.questions[17].correctAnswerIndex = 0;

        // Question 19
        quizData.questions[18] = new QuizData.QuizQuestion();
        quizData.questions[18].questionText = "What was the name of the mythological island Columbus believed he had reached on his first voyage?";
        quizData.questions[18].answerOptions = new string[] { "El Dorado", "Atlantis", "Avalon", "Elysium" };
        quizData.questions[18].correctAnswerIndex = 1;

        // Question 20
        quizData.questions[19] = new QuizData.QuizQuestion();
        quizData.questions[19].questionText = "What was the primary method of navigation used by Columbus during his voyages?";
        quizData.questions[19].answerOptions = new string[] { "Celestial navigation", "Dead reckoning", "Magnetic compass", "GPS" };
        quizData.questions[19].correctAnswerIndex = 2;

        // Question 21
        quizData.questions[20] = new QuizData.QuizQuestion();
        quizData.questions[20].questionText = "Who financed Columbus's voyages to the New World?";
        quizData.questions[20].answerOptions = new string[] { "King Ferdinand and Queen Isabella of Spain", "King Henry VIII of England", "King Louis XIV of France", "King John II of Portugal" };
        quizData.questions[20].correctAnswerIndex = 0;

        // Question 22
        quizData.questions[21] = new QuizData.QuizQuestion();
        quizData.questions[21].questionText = "What was the original goal of Columbus's voyages?";
        quizData.questions[21].answerOptions = new string[] { "To find a direct route to Asia by sailing west", "To explore the coast of Africa", "To establish trading posts in the Caribbean", "To discover new lands for Spain" };
        quizData.questions[21].correctAnswerIndex = 0;

        // Question 23
        quizData.questions[22] = new QuizData.QuizQuestion();
        quizData.questions[22].questionText = "How many voyages did Columbus undertake to the New World?";
        quizData.questions[22].answerOptions = new string[] { "Three", "Four", "Five", "Six" };
        quizData.questions[22].correctAnswerIndex = 1;

        // Question 24
        quizData.questions[23] = new QuizData.QuizQuestion();
        quizData.questions[23].questionText = "Which of the following islands did Columbus NOT visit during his voyages?";
        quizData.questions[23].answerOptions = new string[] { "Jamaica", "Haiti", "Bermuda", "Puerto Rico" };
        quizData.questions[23].correctAnswerIndex = 2;

        // Question 25
        quizData.questions[24] = new QuizData.QuizQuestion();
        quizData.questions[24].questionText = "What was the name of the event that marked the beginning of the European colonization of the Americas?";
        quizData.questions[24].answerOptions = new string[] { "The Age of Discovery", "The Columbian Exchange", "The Treaty of Tordesillas", "The Reconquista" };
        quizData.questions[24].correctAnswerIndex = 1;

        // Question 26
        quizData.questions[25] = new QuizData.QuizQuestion();
        quizData.questions[25].questionText = "Who was the first European to set foot on mainland America, predating Columbus?";
        quizData.questions[25].answerOptions = new string[] { "John Cabot", "Amerigo Vespucci", "Leif Erikson", "Hernan Cortes" };
        quizData.questions[25].correctAnswerIndex = 2;

        // Question 27
        quizData.questions[26] = new QuizData.QuizQuestion();
        quizData.questions[26].questionText = "What was the name of the document that granted Columbus the authority to govern the lands he discovered?";
        quizData.questions[26].answerOptions = new string[] { "The Charter of the Indies", "The Papal Bull", "The Treaty of Seville", "The Capitulations of Santa Fe" };
        quizData.questions[26].correctAnswerIndex = 3;

        // Question 28
        quizData.questions[27] = new QuizData.QuizQuestion();
        quizData.questions[27].questionText = "What was the main goal of Columbus's final voyage?";
        quizData.questions[27].answerOptions = new string[] { "To find a sea route to Asia", "To establish a permanent settlement in the New World", "To search for gold and riches", "To prove the Earth was round" };
        quizData.questions[27].correctAnswerIndex = 2;

        // Question 29
        quizData.questions[28] = new QuizData.QuizQuestion();
        quizData.questions[28].questionText = "What was the name of the explorer who accompanied Columbus on his second voyage and later became his greatest critic?";
        quizData.questions[28].answerOptions = new string[] { "Amerigo Vespucci", "John Cabot", "Martin Waldseemüller", "Francisco de Bobadilla" };
        quizData.questions[28].correctAnswerIndex = 3;


       // Question 30
        quizData.questions[29] = new QuizData.QuizQuestion();
        quizData.questions[29].questionText = "Which of the following statements best describes Columbus's legacy?";
        quizData.questions[29].answerOptions = new string[] { 
            "He was celebrated as a hero during his lifetime and beyond.", 
            "He is remembered for his contributions to world exploration.", 
            "His actions led to the exploitation and suffering of indigenous peoples.", 
            "All of the above." 
        };
        quizData.questions[29].correctAnswerIndex = 3;

    }
}
