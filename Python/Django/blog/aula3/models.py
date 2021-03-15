from django.db import models

class Usuario(models.Model):
    nome = models.CharField(max_length=20)
    email = models.EmailField()
    mensagem = models.TextField()

    def __str__(self):
        return self.nome