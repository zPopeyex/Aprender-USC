using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Principal : MonoBehaviour
{
    public class Pregunta
    {
        public string pregunta;
        public string Respuesta1;
        public string Respuesta2;
        public string Respuesta3;
        public string Respuesta4;
        //correcta: es el numero de respuesta que esta correcta
        public int correcta;
        public bool aprobada;

        public Pregunta(string pregunta, string Respuesta1, string Respuesta2, string Respuesta3, string Respuesta4, int correcta, bool aprobada)
        {
            this.pregunta = pregunta;
            this.Respuesta1 = Respuesta1;
            this.Respuesta2 = Respuesta2;
            this.Respuesta3 = Respuesta3;
            this.Respuesta4 = Respuesta4;
            this.correcta = correcta;
            this.aprobada = aprobada;
        }
    }

    public Text TextoPregunta;
    public Text TextoRespuestas1;
    public Text TextoRespuestas2;
    public Text TextoRespuestas3;
    public Text TextoRespuestas4;

    public static int NPreguntasPlazoleta = 1;
    public static Pregunta[] PreguntasPlazoleta = new Pregunta[NPreguntasPlazoleta];

    // Start is called before the first frame update
    void Start()
    {
        PreguntasPlazoleta[0] = new Pregunta("¿Cuntos dedos tiene un humano?\n(Ejemplo)", "4", "10", "20", "5", 3, false);
    }

    // Update is called once per frame
    void Update()
    {
        TextoPregunta.text = PreguntasPlazoleta[0].pregunta;
        TextoRespuestas1.text = PreguntasPlazoleta[0].Respuesta1;
        TextoRespuestas2.text = PreguntasPlazoleta[0].Respuesta2;
        TextoRespuestas3.text = PreguntasPlazoleta[0].Respuesta3;
        TextoRespuestas4.text = PreguntasPlazoleta[0].Respuesta4;

    }
}
