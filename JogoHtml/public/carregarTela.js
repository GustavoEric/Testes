export default function carregarTela(tela,jogo,requestAnimationFrame,currentJogadorId){
    const context = tela.getContext('2d')
    context.fillStyle = 'white'
    context.clearRect (0,0,10,10)
    for(const jogadorId in jogo.estado.jogadores){
        const jogador = jogo.estado.jogadores[jogadorId]
        context.fillStyle = 'black'
        context.fillRect(jogador.x,jogador.y,1,1)
    }

    for(const armaId in jogo.estado.armas){
        const arma = jogo.estado.armas[armaId]
        context.fillStyle = 'green'
        context.fillRect(arma.x,arma.y,1,1)
    }
    const currentJogador = jogo.estado.jogadores[currentJogadorId]

    if(currentJogador){
        context.fillStyle = '#F0DB4F'
        context.fillRect(currentJogador.x,currentJogador.y,1,1)
    }

    requestAnimationFrame(() =>{
        carregarTela(tela,jogo,requestAnimationFrame,currentJogadorId)
    })
}