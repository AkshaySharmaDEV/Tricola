using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONReader : MonoBehaviour
{

    public TextAsset QuizJSON;

    [System.Serializable]


    public class Questions
    {
        public string question;
        public string option1;
        public string option2;
        public string option3;
        public string option4;

    }

    [System.Serializable]

    public class Questionlist
    {
        public Questions[] questionlabel;
    }

    public Questionlist myQuestionlist = new Questionlist();


    // Start is called before the first frame update
    void Start()
    {

        myQuestionlist = JsonUtility.FromJson<Questionlist>(QuizJSON.text);
        
    }

    // Update is called once per frame
    void Update()
    {
        myQuestionlist = JsonUtility.FromJson<Questionlist>(QuizJSON.text);
        
    }
}
