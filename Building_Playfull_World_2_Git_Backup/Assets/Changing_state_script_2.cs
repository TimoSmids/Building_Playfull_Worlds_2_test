using UnityEngine;

public class ShaderChanger : MonoBehaviour
{
    public Material material; // Reference to the material you want to change the shader of
    public Shader newShader; // Reference to the new shader you want to apply

    private Renderer renderer_1;
    private Animator Ani_Cntr_Shader_Cube;

    private void Start()
    {
        renderer_1 = GetComponent<Renderer>();
        Ani_Cntr_Shader_Cube = GetComponent<Animator>(); // Add this line to get a reference to the Animator component
    }

    public void ChangeShader()
    {
        if (Ani_Cntr_Shader_Cube.GetBool("pink"))
        {
            renderer_1.material.shader = newShader;
        }
    }
}
