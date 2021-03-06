﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using CellsDragNDrop;

namespace CellsDragNDrop
{
    public class Language : MonoBehaviour
    {
        public static Language instance;
        public static List<Word> words = new List<Word>();
        public enum Lang { eng, ru };
        public Lang currentLang = Lang.eng;
        public Text shopBttn;
        public Text recycle;
        public Text pointsName;
        public Text shopTitle;
        const string xmlFileName = "language";

        void Awake()
        {
            instance = this;
            ParseXML();
            RenameElements();
        }

        void ParseXML()
        {
            TextAsset textAsset = Resources.Load(xmlFileName) as TextAsset;
            MemoryStream stream = new MemoryStream(textAsset.bytes);
            XmlReader reader = XmlReader.Create(stream);
            XDocument configXML = XDocument.Load(reader);
            IEnumerable<XElement> elements = from el in configXML.Descendants("word") select el;
            foreach (XElement wordEl in elements)
            {
                Word word = new Word(wordEl);
                words.Add(word);
            }
            //foreach (var w in words) Debug.Log(w.value);
        }

        void RenameElements()
        {
            foreach (var w in words)
            {
                if (w.id == 1) shopBttn.text = w.value;
                else if (w.id == 2) recycle.text = w.value;
                else if (w.id == 3) pointsName.text = w.value;
                else if (w.id == 4) shopTitle.text = w.value;
            }
        }
    }
    public class Word
    {
        public int id;
        public string value;
        public Word(XElement tmp)
        {
            id = (int)tmp.Attribute("id");
            value = (string)tmp.Attribute(Language.instance.currentLang.ToString());
        }
    }
}