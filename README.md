# 원자재 재고 관리 시스템

## 개요

원자재 재고 관리 시스템에 가공품 납품 관리를 추가하고 Devexpress를 이용한 차트구현을 추가하였음

## 개발기간
2020년 12월 14일 ~ 12월 18일

## 개발 환경

### 언어
- C# 8.0

### 프레임워크
- .Net FrameWork 4.8
- EntityFrameWork 6.2
- Winform

### 데이터베이스
Microsoft MS-SQL Server 2019

### 기타 개발환경
- Windows 10
- Microsoft Visual Studio Community 2019 v16.8
- Microsoft SQL Server Management Studio v18.6

## DB 스키마

![Table](https://user-images.githubusercontent.com/74530618/102707618-f924a280-42df-11eb-9be1-14c2cc6cdd7f.jpg)

  - 모든 항목이 제 3 정규화까지 완료되었다.
  
## 차트 화면 목록
### 1. 원자재 시세

#### 3개월간의 원자재 시세를 Line Chart로 표시

- 원자재별 체크박스로 표시할 원자재 선택
- 시작날짜, 종료날짜 선택으로 기간조회가능
  - 기간 선택 오류
    - 기간을 잘못 선택했을시 메시지 박스 출력

![원자재 시세조회](https://user-images.githubusercontent.com/74530618/102707792-4d7c5200-42e1-11eb-822c-536a4af1ccd2.jpg)


### 2. 광물별 구매비율

#### 원자재별로 현시점까지 구매한 비율을 Pie Chart로 표시

![광물별 구매비율](https://user-images.githubusercontent.com/74530618/102734812-190da200-4384-11eb-85fb-6eb538751b69.jpg)


### 3. 원산지별 광물 구매량

#### 원산지에서 구매한 광물 총량을 Bubble Chart로 표시

-버블 클릭시 광물별 상세 판매량을 바차트로 표시


### 4. 제품군별 판매량

#### Product 테이블의 제품군별 판매량을 Pie Chart로 표시

![제품군별 판매량](https://user-images.githubusercontent.com/74530618/102708008-1c048600-42e3-11eb-9eb8-a52e57e8c008.jpg)


### 5. 기간당 매출이익

#### 기간당 제품판매이익, 광물구매비, 인건비, 유지보수비, 운송비 등을 합산한 매출이익을 피벗테이블로 표시


### 6. 기간당 지출

#### 인건비, 유지보수비, 운송비, 자원구매비를 기간별로 3DLine Chart로 표시

![기간당 지출](https://user-images.githubusercontent.com/74530618/102708197-89fd7d00-42e4-11eb-8657-2b20810e12f3.jpg)


### 7. 영업이익

#### 영업팀별 목표건수와 달성건수를 Side-by-Side Bar Chart로 표시

![영업이익](https://user-images.githubusercontent.com/74530618/102708254-fc6e5d00-42e4-11eb-85bd-e1e346706f2c.jpg)


### 8. 회사성장률

#### 자사포함 경쟁사의 전년도 및 각 분기대비 성장률을 Side-by-Side Bar Chart와 Line Chart로 표시

![회사 성장률](https://user-images.githubusercontent.com/74530618/102708320-7b639580-42e5-11eb-8c9c-308972379d1c.jpg)

## 발생한 이슈
 1. 원자재 구매비율 차트 - 범례가 원자재 이름으로 표현되지않는 문제
 
## 원인
 1. 차트 데이터에 Resource테이블의 Name컬럼이 추가되지않음
## 해결 방법

