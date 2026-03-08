using System;

void Run() {
    Seat s1 = new Seat("김민수");
    Seat s2 = new Seat("이지영");
    Seat s3 = new Seat("박서준");
    s1.Study();
    s2.Study();
    s3.Study();

    Seat.ShowStatus();

    s1 = null;
    s2 = null;
    s3 = null;
}
Run();

GC.Collect();
GC.WaitForPendingFinalizers();  // 소멸자 실행 대기
GC.Collect();

Seat.ShowStatus();