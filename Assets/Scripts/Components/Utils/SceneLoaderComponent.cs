using UnityEngine;
using UnityEngine.SceneManagement;

namespace TestTask.Utils
{
    public sealed class SceneLoaderComponent : MonoBehaviour
    {
        public void LoadScene(int sceneId)
        {
            SceneManager.LoadScene(sceneId);
        }
    }
}