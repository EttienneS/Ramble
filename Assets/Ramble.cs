using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Ramble : MonoBehaviour
{
    public Text Word1;
    public Text Word2;

    public TextAsset WordList;

    private List<string> _words;

    public void GetWords()
    {
        Word1.text = _words[Random.Range(0, _words.Count)];
        Word2.text = _words[Random.Range(0, _words.Count)];
    }

    private void Start()
    {
        _words = WordList.text.Split('\n').ToList();
        GetWords();
    }
}