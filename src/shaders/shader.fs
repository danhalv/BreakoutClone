#version 330 core
in vec2 vTexCoord;

uniform sampler2D uMyTexture;

out vec4 FragColor;

void main() {
        vec4 background = vec4(0.5f, 0.5f, 0.5f, 1.0f);
        vec4 tex = texture(uMyTexture, vTexCoord);
        vec4 color = min(tex, vec4(1.0f, 1.0f, 1.0f, 1.0f));
        vec4 result = background * color;
        FragColor = result;
}