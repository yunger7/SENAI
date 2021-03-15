from django import forms
from .models import Usuario

class FormularioUsuario(forms.ModelForm):
    class Meta:
        model = Usuario
        fields = ['nome', 'email', 'mensagem']