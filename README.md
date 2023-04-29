# GameFlowSample
## Unityでのゲームフロー制御サンプル

VContainer ＋ MessagePipe + MVRP で画面遷移をするだけのサンプル

- VContainer
  - DIによるシーン単位での依存関係の明確化
  - DIコンテナによるSingletonの排除
  - EntryPointによるコード起点を明確にし、初期化のタイミングを制御したい
  - 
- MV(R)Pパターン
  - Model ：ゲームロジック、データの管理
  - View ： 描画や入出力、ロジックに絡まないオブジェクトの動作など
  - Presenter ： ModelとViewの仲介
  - Reactive ： オブジェクト間の連携に活用
- MessagePipe
  - クラスの疎結合

## サンプルの目指すところ
  - ゲームの機能実装をスムーズにするために機能ごとの役割を明確にしていく
  - クラスの依存度を下げ、開発中の試行錯誤があっても柔軟に変更可能にする
  - Singletonは使わない。どこからでも利用できるのはいいが開発が進むと雑になり、初期化のタイミングが曖昧になりがちなため。
  - DontDestroyOnLoadではなく、RootLifeTimeScopeを使いシーンを跨いでゲーム全体でどこからでも使える機能を一括管理する
  - サンプルではEntryPointをPresenterにしているが、これは状況に応じて変えて良さそう
