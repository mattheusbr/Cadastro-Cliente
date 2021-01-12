function buscarcep(cep) {
    var _cep = cep.replace(/\D/g, '');

    if (_cep !== "") {

        var verificacep = /^[0-9]{8}$/;

        if (verificacep.test(_cep)) {

            document.getElementById('logradouro').value = "Pesquisando...";
            document.getElementById('bairro').value = "Pesquisando...";
            document.getElementById('cidade').value = "Pesquisando...";
            document.getElementById('estado').value = "Pesquisando...";
            desabilita_campos_endereco();

            var script = document.createElement('script');
            script.src = '//viacep.com.br/ws/' + cep + '/json/?callback=chamada';
            document.body.appendChild(script);

        } 
        else {
            limpa_campos_enderecos();
            habilita_campos_endereco();
            alert("Formato de CEP inválido.");
        }
    } 
    else {
        limpa_campos_enderecos();
        habilita_campos_endereco();
        alert("Campo CEP obrigatório para efetuar a busca!");
    }
}

function desabilita_campos_endereco() {

    document.getElementById('logradouro').disabled = true;
    document.getElementById('bairro').disabled = true;
    document.getElementById('cidade').disabled = true;
    document.getElementById('estado').disabled = true;

}
function habilita_campos_endereco() {
    document.getElementById('logradouro').disabled = false;
    document.getElementById('bairro').disabled = false;
    document.getElementById('cidade').disabled = false;
    document.getElementById('estado').disabled = false;
}

function chamada(conteudo) {
    if (!("erro" in conteudo)) {
        document.getElementById('logradouro').value = (conteudo.logradouro);
        document.getElementById('bairro').value = (conteudo.bairro);
        document.getElementById('cidade').value = (conteudo.localidade);
        document.getElementById('estado').value = (conteudo.uf);
        habilita_campos_endereco();
    } 
    else {
        limpa_campos_enderecos();
        document.getElementById('cep').value = ("");
        habilita_campos_endereco();
        alert("CEP não encontrado.");

    }
}

function limpa_campos_enderecos() {
    document.getElementById('logradouro').value = ("");
    document.getElementById('bairro').value = ("");
    document.getElementById('cidade').value = ("");
    document.getElementById('estado').value = ("");
}