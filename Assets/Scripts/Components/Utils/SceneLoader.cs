using UnityEngine;
using UnityEngine.SceneManagement;

namespace TestTask.Utils
{
    public sealed class SceneLoader : MonoBehaviour
    {
        public void LoadScene(int sceneId)
        {
            SceneManager.LoadScene(sceneId);
        }
    }
}