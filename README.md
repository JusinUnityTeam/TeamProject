# 0. TeamProject
팀 작업 공간입니다.





# 1. 네이밍 컨벤션
0) 전체
- 어절마다 대문자
- 헝가리안 (클래스 & 구조체 제외)
예)
기본타입 int iCnt;
열거형 E_Type / en_Type
인터페이스 IJob

1) 변수
- 첫글자 소문자
- 최대한 명사로(bool은 예외 is, able, can 가능)

- 최대한 짧게 
X : numberOfCharacter
O : numCharacter / characterNum / characterCnt
- 용처를 알기 쉽게 이름짓기( 힘들면 주석)

2) 함수
- 동사
- 첫글자 대문자
- 용처 알기 쉽게 이름짓기
예) GetObjectState();
- 주석 명세
// Description :
// Parameter :
// Return :

3) 클래스 & 구조체
- 명사
- 첫글자 대문자

4) 인터페이스(순수 가상 클래스)
- 대문자 아이(I) 붙이기
예) ICursor





# 2. 깃허브 커밋 설명 포멧
기본 : [작업행위_이름이니셜] 작업 내역 // 작업 행위와 이름 이니셜은 대문자로 쓴다.
예외 : 리드미와 같이 작업 이외의 내용은 자유 포멧
작업 행위
1) ADD : 새로운 컨텐츠 추가
2) UPDATE : 기존 컨텐츠 보완/변경
3) DELETE : 기존 컨텐츠 삭제
4) MERGE : 브랜치를 마스터에 머지 (최종 x)
5) RELEASE : 마스터에 최종 머지(일주일 단위/버젼 작성/마지막 병합자가 작성)
Ex1. [ADD_SJH] 오디오 매니저를 추가 // 단일 내역 추가
Ex2. [UPDATE_SJH] 오디오 매니저&게임 매니저 개선 // 같은 작업 행위 복수 내역 추가
Ex3. [ADD_SJH] 자동차 모델 추가 / [UPDATE_SJH] 몬스터 AI 개선 
// 되도록 자주 커밋하여 하나의 내역만 올리도록 하자.





# 3. 보고서 작성 주기
일주일 단위로 화요일마다 구글워드로 작성한다. 
