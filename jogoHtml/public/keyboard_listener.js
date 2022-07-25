export default function createKeyboardListener(){
    const estado = {
        observadores: [],
        jogadorId: null
    }

    function inscreverJogadorId(jogadorId){
        estado.jogadorId = jogadorId
    }

    function inscrever(observadorFuncao){
        estado.observadores.push(observadorFuncao)
    }

    function notificarTodos(command){
        console.log('Notificando ',estado.observadores.length, 'Observadores')

        for (const observadorFuncao of estado.observadores){
            observadorFuncao(command)
        }
    }
    document.addEventListener('keydown',handleKeydown)

    function handleKeydown(event){
        const keyPressed = event.key

        const command = {
            type:'move-jogador',
            jogadorId: estado.jogadorId,
            keyPressed
        }

        notificarTodos(command)
    }
    return{
        inscrever,
        inscreverJogadorId
    }
}