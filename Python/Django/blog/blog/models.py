from django.db import models
from django.contrib.auth.models import User
from django.utils import timezone

class Postagem(models.Model):
    STATUS_CHOICE = (('rascunho','Rascunho'), ('publicado', 'Publicado'))

    titulo = models.CharField(max_length=250)
    rotulo = models.SlugField(max_length=250, unique_for_date='data_publicacao')
    autor = models.ForeignKey(User, on_delete=models.CASCADE, related_name='blog_postagem')
    mensagem = models.TextField()
    data_publicacao = models.DateTimeField(default=timezone.now)
    data_criacao = models.DateTimeField(auto_now_add=True)
    data_atualizacao = models.DateTimeField(auto_now=True)
    status = models.CharField(max_length=10, choices=STATUS_CHOICE, default='rascunho')

    def __str__(self):
        return self.titulo




