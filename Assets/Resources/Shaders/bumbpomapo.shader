Shader "Custom/bumbpomapo"
{
    Properties
    {
        _MainTint("Diffuse Tint", Color) = (0,1,0,1)
        _NormalTex("Normal Map", 2D)= "bumb" {}
    }
    SubShader
    {
        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        sampler2D _NormalTex;
        float4 _MainTint;

        struct Input
        {
            float2 uv_NormalTex;
        };


        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            o.Albedo= _MainTint;

            float3 normalMap= UnpackNormal(tex2D(_NormalTex,IN.uv_NormalTex));

            o.Normal = normalMap.rgb;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
