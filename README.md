# Trabalho Final RV

Descrição Prévia

Trabalho proposto:

Jogo da luz: Pressionar o “botão” sempre que tiver luz amarela e não pressionar quando tiver luz vermelha. Aparecer vermelha e amarela juntas, mas isso significa que a criança não deve apertar o botão. Acrescentar distratores, ex: objeto caindo e o “som” que faz ao cair. Acrescentar fases. Colocar um coração com a quantidade de “vidas” que ainda possui. A cada bolinha vermelha que o indivíduo aperta o botão, perde uma vida. Aumentar a velocidade e quantidade em que aparecem as luzes amarelas e vermelhas.

Evolução do trabalho:

Primeiramente, foram construidos, através do editor Blender, uma tabela com 6 “Luzes” piscantes e um coração, ambos sem texturização (Assets/ tabela_piscapisca2.blend e Assets/ Heart); A função “espelho” do Blender foi utilizada na tabela, facilitando não só o trabalho a ser feito (apenas meia tabela foi construída) mas também garantindo a simetria perfeita do objeto.

Para a separação das luzes como objetos individuais e independentes, através do próprio Blender, as faces que representariam as “luzes” foram retiradas e salvas em um arquivo separado (Assets/ tabela_piscapisca2_complementador), inseridas dentro da Engine Unity e arrastadas manualmente para suas respectivas posições; Para garantir que nenhum ponto ficasse fora do normal, todas as “luzes” tinham exatamente o mesmo tamanho (isso foi feito dividindo a face central da tabela em faces idênticas, então a partir daí a função Excrude foi utilizada em 4 das faces da tabela, para enfeitar a tabela colocando curvas, o comando Ctrl+B foi utilizado simultaneamente em cada uma das luzes, garantindo a manutenção da simetria.

Após a introdução de todos os objetos, 4 corações foram inseridos e posicionados em cima da tabela, neles foram inseridos um script de mudança leve de cor, quase imperceptível, fazendo o coração brilhar entre rosa e um rosa mais escuro

Para a mudança de cor das “luzes” da tabela, foi utilizado o seguinte ponto do código, contido no script (Assets/ Change_Color2.cs)

 
A função Random.Range foi utilizada para garantir a “aleatoriedade” das cores que seriam postas sobre cada luz a cada Update, como cada luz, apesar de receber o mesmo script, são objetos diferentes, o script rodou em cada luz e o sucesso foi obtido: cada luz recebeu uma cor diferente, que são atualizadas a cada “Number of Seconds”, ou “Número de segundos”.

Um contador de ciclos foi inserido “Timer” no código para futuramente ser utilizado na utilização do sistema de pontuação e critérios para quaisquer outras funções desejadas (Exemplo: Começar o programa com apenas 4 luzes piscando, ao contador de 10 ciclos (10*nº de segundos) iniciar a 5ª e 6ª luz, ao contador de 20 ciclos (20*nº de segundos) aumentar a velocidade dos piscadores para y (sendo y < nº de segundos), ao contar x ciclos (sendo x*nº de segundos = 180 segundos = 3 minutos) encerrar o programa e exibir a pontuação total.


Etapas futuras:

1.	Fazer um coração desaparecer ao clicar e uma das luzes estiver vermelha
2.	Fazer um sistema de pontuação funcional
3.	Definir critérios para o sistema de pontuação não ficar banal, e sim dinâmico para a possibilidade de melhores análises da criança utilizadora do Software (Ex: Ao clicar e não tiver nem vermelho e nem amarelo entre as luzes, perder x pontos ao invés de perder um coração)
4.	Inserir distrações pelo mapa através de sons localizados
5.	Verificar e se necessário, remodelar e melhorar a tabela
6.	Texturizar e aplicar o mapeamento UV na tabela e, se necessário, nos corações
7.	Criar um ambiente externo amigável (uma casa, um bosque, etc…)
8.	Criar, se necessário, um menu onde serão definidos: nº de segundos iniciais, nº de segundos após ⅓ do tempo do programa, tempo que o programa irá rodar.


### Atualizações ###

Atualização #01

Tempo total do programa definido: 300s = 5m
(ao final todas as luzes ficam verdes)

Tempo para iniciar a quinta e a sexta luz: 150s = 2m30s

Tempo inicial do PiscaPisca: 4s

Tempo final do PiscaPisca: 2s
(o tempo é diminuído gradativamente a cada 60s em 0.5s)

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Critérios de pontuação (a ser implementado):

Clicar com uma (ou mais) luz amarela e nenhuma vermelha: adicionar 20 + (10*nº corações/2) pontos
Clicar com nenhuma luz amarela nem vermelha: subtrair 20 pontos
Clicar com luz vermelha: perde um coração
Não clicar com luz amarela: subtrair 20 pontos

*Objetivo dos critérios dinâmicos: visando um trabalho que será utilizado no futuro, com esses atributos
dinâmicos é possível medir um crescimento real do desempenho da criança que o está utilizando, ao invés do sistema
simples de pontuação (clico com amarelo ganha 1 pontos, clicou com vermelho perde uma vida)

*A adição da consideração do número de corações faz com que o jogo fique "competitivo" e a criança não queira perder
nenhum coração para não receber menos pontos

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

A Adicionar:

Adicionar luzes direcionadas em cada objeto para parecer PiscaPisca de verdade

Efeito de sumiço de coração (colocar um bool em cada coração e um script na tabela) 

Efeito de game over (script na tabela)

Contador de pontos (script na tabela) *definir se o contador vai ficar exposto na tabela como se estivesse
"pintado" ou se vai ficar fixo na tela do jogador

Distrações com som (não faço a mínima ideia de como vou fazer isso)

Embelezamento e mapeamento UV da tabela, Criação ou importação de ambiente (etapa final)