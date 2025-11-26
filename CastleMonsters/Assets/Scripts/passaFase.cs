    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;
    using UnityEngine.SceneManagement;
    public class passaFase : MonoBehaviour
    {   
        public MonoBehaviour playerScritp;
        public GameObject som;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        void trocaCena() {
            SceneManager.LoadScene("Fase2");
        }
        

        private void OnCollisionEnter2D(Collision2D col) {
            if(col.gameObject.CompareTag("Player")) {
                trocaCena();

            }
        }
    }
