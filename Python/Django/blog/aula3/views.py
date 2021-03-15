from django.shortcuts import render
from .forms import FormularioUsuario
from .models import Usuario

def cadastrar_usuario(request):
    formulario = FormularioUsuario()

    if(request.method == 'POST'):
        formulario = FormularioUsuario(request.POST)

        if(formulario.is_valid()):
            usuario_nome = formulario.cleaned_data['nome']
            usuario_email = formulario.cleaned_data['email']
            usuario_mensagem = formulario.cleaned_data['mensagem']

            novo_usuario = Usuario(nome = usuario_nome, email = usuario_email, mensagem = usuario_mensagem)
            novo_usuario.save()
    else:
        formulario = FormularioUsuario()

    return render(request, 'aula3/formulario.html', {'formulario':formulario})
