#language: pt
Funcionalidade: Cadastro dados do Veículo

@dados_veiculo
Cenario: Cadastrar dados do veículo
    Dado que eu esteja logado no site
    Quando estiver no formulário da aba “Enter Vehicle Data”, implementar pelo menos duas validações de campo
    E em seguida preencher os campos faltantes do formulário
    Então preencher o formulário da aba “Enter Insurant Data”