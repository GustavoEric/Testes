export default function criarJogo(){
    const estado = {
        jogadores:{},
        armas:{},
        tela:{
            width:10,
            height:10,
        }
    }

    const observadores = []

    function inscrever(observadorFuncao){
        observadores.push(observadorFuncao)
    }

    function notificarTodos(command){
        for (const observadorFuncao of observadores){
            observadorFuncao(command)
        }
    }
    function setEstado(novoEstado){
        Object.assign(estado,novoEstado)
    }

    function addJogador(command){
        const jogadorId = command.jogadorId
        const jogadorX = 'jogadorX' in command ? command.jogadorX : Math.floor(Math.random() * estado.tela.width)
        const jogadorY = 'jogadorY' in command ? command.jogadorY : Math.floor(Math.random() * estado.tela.height)

        estado.jogadores[jogadorId] = {
            x: jogadorX,
            y: jogadorY
        }

        notificarTodos({
            type: 'add-jogador',
            jogadorId: jogadorId,
            jogadorX: jogadorX,
            jogadorY: jogadorY
        })
    }

    function removerJogador(command){
        const jogadorId = command.jogadorId

        delete estado.jogadores[jogadorId]

        notificarTodos({
            type: 'remove-jogador',
            jogadorId: jogadorId
        })
    }
    function addArmas(command){
        const armaId = command.armaId
        const armaX = command.armaX
        const armaY = command.armaY

        estado.armas[armaId] = {
            x: armaX,
            y: armaY
        }
    }

    function removerArma(command){
        const armaId = command.armaId

        delete estado.armas[armaId]
    }

    function moveJogador(command){
        console.log('Movendo ',command.jogadorId,'Com ',command.keyPressed)
        notificarTodos(command)

        const movimentosAceitos = {
            ArrowUp(jogador){
                console.log('Movendo Jogador para cima')
                if (jogador.y -1 >= 0){
                    jogador.y -=1
                }
            },
            ArrowDown(jogador){
                console.log('Movendo Jogador para baixo')
                if (jogador.y +1 < estado.tela.height){
                    jogador.y +=1
                }
            },
            ArrowRight(jogador){
                console.log('Movendo Jogador para direita')
                if (jogador.x+1 < estado.tela.width){
                    jogador.x +=1
                }
                
            },
            ArrowLeft(jogador){
                console.log('Movendo Jogador para esquerda')
                if (jogador.x-1 >=0){
                    jogador.x -=1
                }
            }
        }

        const keyPressed = command.keyPressed
        const jogadorId = command.jogadorId
        const jogador = estado.jogadores[command.jogadorId]
        const moverFuncao = movimentosAceitos[keyPressed]
        
        if (jogador && moverFuncao){
            moverFuncao(jogador)
            colisaoArmas(jogadorId)
        }
    }

    function colisaoArmas(jogadorId){
            const jogador = estado.jogadores[jogadorId]

            for(const armaId in estado.armas){
                const arma = estado.armas[armaId]
                console.log('Checando Colisao do Jogador com a Arma ')

                if(jogador.x == arma.x && jogador.y== arma.y){
                    console.log('O Jogador: ',jogadorId,'Colidiu com a Arma: ',armaId)
                    removerArma({armaId: armaId})
                }
            }
    }
    return{
        addJogador,
        removerJogador,
        moveJogador,
        addArmas,
        removerArma,
        estado,
        setEstado,
        inscrever
    }
}