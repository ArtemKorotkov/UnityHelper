using System;
using UnityEngine;
using UnityEngine.UI;

namespace Source
{
    public class View : MonoBehaviour, IView

    {
        [SerializeField] private Button back;
        [SerializeField] private CanvasGroup _canvasGroup;

        public event Action OnClickToBack;
        public bool IsShowen { get; private set; }


        private void Awake()
        {
            back?.onClick.AddListener(ClickToBack);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
            IsShowen = false;
        }

        public void Show()
        {
            gameObject.SetActive(true);
            IsShowen = true;
        }

        private void ClickToBack()
        {
            OnClickToBack?.Invoke();
        }
    }
}