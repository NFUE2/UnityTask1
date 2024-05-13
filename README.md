# Unity 게임개발 입문 개인 과제

## 필수요구사항
#### 1.캐릭터만들기
![image](https://github.com/NFUE2/UnityTask1/assets/96811655/763f8edf-b4e3-472b-b2c8-e79ba34bd816)
![image](https://github.com/NFUE2/UnityTask1/assets/96811655/4fb0c06a-d7ed-4638-8059-034c55c3f876)

유니티 강좌에서 배웠던것을 복습하는 차원에서 빈게임오브젝트를 생성하고   
그 아래 자식 게임오브젝트에 SpriteRenderer컴포넌트에 캐릭터 이미지가 나오도록 하였습니다.

#### 2.캐릭터 이동
![image](https://github.com/NFUE2/UnityTask1/assets/96811655/5d699cf3-9d3d-4367-9bf2-a99374db0e10)
![image](https://github.com/NFUE2/UnityTask1/assets/96811655/682cb8fa-496a-4697-8a01-6d0651459261)   
![image](https://github.com/NFUE2/UnityTask1/assets/96811655/937fbe89-7f7e-4936-b26b-6931d2fc37ff)   
![Move](https://github.com/NFUE2/UnityTask1/assets/96811655/a22c256b-1ced-4613-8780-e39a5b382b86)

이 부분도 유니티 입문강의 복습차원에서 Input System 을 활용하여 구현하였습니다.   
키보드 WASD를 이용하여 이동하고 캐릭터가 마우스가 있는 위치를 바라봅니다.

#### 3.방 만들기
![image](https://github.com/NFUE2/UnityTask1/assets/96811655/d6b1a92f-8619-40f4-bac9-e4fcd55bc9d8)

![image](https://github.com/NFUE2/UnityTask1/assets/96811655/9076ae72-cd71-4821-9b83-39196b4a9f81)

방꾸미기가 제일 어렵더라구요, 이쁘게 꾸미려다가 망한게 몇번인지 모르겠습니다...   
그래서 간단하게 만들었습니다 ㅠㅠ 외벽에 TilemapCollider2D 컴포넌트를 이용하여 벽을 만들어주었습니다.
벽을 만들고 플레이 했을때 캐릭터가 벽에 부딫쳐 회전하는일이 발생해서 회전을 고정해주었습니다.

#### 4.카메라 따라가기

![image](https://github.com/NFUE2/UnityTask1/assets/96811655/9d70f076-1e5a-49df-ad07-accd55c673b0)

카메라를 플레이어의 자식에 위치시켜서 따라가도록 만들었습니다.

#### 5.캐릭터 애니메이션 추가
![image](https://github.com/NFUE2/UnityTask1/assets/96811655/dec38c3c-b85c-4a0e-a83f-4999be522ca6)

![image](https://github.com/NFUE2/UnityTask1/assets/96811655/b9743dfe-6b37-409b-8504-623f8b3dcba1)


위 필수2에서 gif파일에 보시면 움직이는 모습을 볼 수 있습니다. 가만히 있을때 Idle이 작동됩니다.   
다른 캐릭터를 만들때 Animator Override Contorller를 이용하여 만들었습니다.

#### 6.이름 입력 시스템

![Nickname](https://github.com/NFUE2/UnityTask1/assets/96811655/ba281188-6467-4923-beb3-53a3390d4675)

![image](https://github.com/NFUE2/UnityTask1/assets/96811655/abf39579-a2c9-4f29-a56a-f23d9e4058f0)
![image](https://github.com/NFUE2/UnityTask1/assets/96811655/f964b71b-fde3-450c-9ecb-27d4d0aba925)

![image](https://github.com/NFUE2/UnityTask1/assets/96811655/2c5af6b7-6fe0-4cd1-81a4-7c578b643b01)

처음화면에서 닉네임을 입력하고 설정할 수 있도록 만들었습니다.   
코드를 작성하긴 했는데...더 간단한 방법이 있을것같은데 고민을 해봐야할것같습니다.
Text컴포넌트에 바로 닉네임을 입력할수도있는데 선택2번에서의 이름바꾸기를 하려다보니 조금 지저분하다는 생각이 들었습니다.

#### 7.캐릭터 선택 시스템
![ChangetCharacter](https://github.com/NFUE2/UnityTask1/assets/96811655/835e7228-2c5b-4af1-ae5e-95e906071485)   
![image](https://github.com/NFUE2/UnityTask1/assets/96811655/a1f77355-fcb7-418e-833e-805b9f5ed613)

![image](https://github.com/NFUE2/UnityTask1/assets/96811655/db5745a5-95bf-4c73-ab3a-ebc5660250a2)


맵으로 들어가기전 캐릭터를 클릭해서 캐릭터를 바꿀 수 있습니다.   
처음엔 캐릭터 2개를 만들고 버튼으로 선택하지않은 캐릭터를 비활성화하고 선택한 캐릭터를 활성화하는 방식으로 구현했는데   
버튼이 너무 지저분해지고 게임오브젝트 1개로 돌려쓰고 싶은 생각이 들었고 유니티 입문에서 알게된 SciprtableObject를 써보고 싶었습니다.

## 선택
#### 1. 시간 표시

![image](https://github.com/NFUE2/UnityTask1/assets/96811655/235e5d9c-7ea0-4969-a7cc-4b613cc98c0d)

![image](https://github.com/NFUE2/UnityTask1/assets/96811655/4b64f3b3-9202-4b67-b955-b2c1482b67ca)

화면 좌상단에 시간이 표시되도록 만들었습니다

#### 2. 인게임 이름 바꾸기

![ChangeNickname](https://github.com/NFUE2/UnityTask1/assets/96811655/62b24529-2341-4c32-a9cb-0cf222d8f970)

필수6에서의 이름설정하는 부분을 재활용했습니다. 하단 [닉네임변경]을 클릭하면 닉네임을 변경하는 창이 활성화됩니다.

#### 3.참석 인원 UI

![ViewUser](https://github.com/NFUE2/UnityTask1/assets/96811655/b96de377-3ee3-495f-a624-842354e69b34)


![image](https://github.com/NFUE2/UnityTask1/assets/96811655/3e3f0e76-c846-4379-a488-654b419a977a)

우측하단 [참석자] 버튼을 클릭하면 현재 접속중인 사람들을 표시하게 만들었습니다.

#### 4. 인게임 캐릭터 선택

![ChangeCharacter2](https://github.com/NFUE2/UnityTask1/assets/96811655/d6df5530-ab6a-4b2a-8212-629350797375)

필수7번 부분을 재활용 하였습니다. [캐릭터선택]버튼을 클릭하면 캐릭터 선택이 활성화됩니다.


#### 5. NPC 대화

![Interaction](https://github.com/NFUE2/UnityTask1/assets/96811655/21326813-68ec-4fa9-ac43-b94117fe3127)

![image](https://github.com/NFUE2/UnityTask1/assets/96811655/2e4db45c-d139-4aba-929e-e0e1c0840d2d)
![image](https://github.com/NFUE2/UnityTask1/assets/96811655/d625e7c7-fdcd-4dff-a1ca-4019dc71beb8)

매니저님 오브젝트의 Collider2D를 설정하여 접촉하게되면 활성화되도록 하였습니다.


